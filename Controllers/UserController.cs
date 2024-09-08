namespace API.Controllers;

/// <summary>
/// UserController
/// </summary>
/// <returns></returns>
[ApiVersion("1.0")]
[ApiVersion(0.9, Deprecated = true)]
public class UserController(IMediator mediator, ILogger logger, ApiDbContext apiDbContext,
    IUserRepository userRepository,
    MAuthenticateTokenHelper authTokenHelper,
    IDistributedCache distributedCache) : MControllerBase(mediator, logger)
{
    private readonly MAuthenticateTokenHelper _authTokenHelper = authTokenHelper;
    private readonly ApiDbContext _apiDbContext = apiDbContext;
    private readonly IUserRepository _userRepository = userRepository;

    // Register
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto command)
    {
        MResponse<object> result = new();
        bool userExist = await UserIsExistAsync(command.UserName);
        if (userExist)
        {
            result.AddApiErrorMessage("User already exists", [command.UserName]);
            return Ok(result);
        }

        MUser userInfo = new()
        {
            Name = command.Name,
            Surname = command.Surname,
            UserName = command.UserName,
            EmailAddress = command.EmailAddress,
            Password = MPasswordHelper.HashPassword(command.Password, out string salf),
            Salf = salf
        };

        _ = await _apiDbContext.AddAsync(userInfo);
        _ = await _userRepository.UnitOfWork.SaveChangesAsync();

        GenerateToken(userInfo, out string accessToken, out string refreshToken, out _);

        result.Result = new
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken
        };

        return Ok(result);
    }

    // Login
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto command)
    {
        MResponse<object> result = new();
        MUser? user = await _apiDbContext.Users.FirstOrDefaultAsync(x => x.UserName == command.Username);
        if (user == null)
        {
            result.AddApiErrorMessage("User does not exist", [command.Username]);
            return Ok(result);
        }

        await distributedCache.SetCacheAsync("USER", user, DistributedRedisOptions.DefaultCacheOptions_10_5);

        if (string.IsNullOrEmpty(user.Salf))
        {
            result.AddApiErrorMessage("001", [command.Username]);
            return Ok(result);
        }

        if (!MPasswordHelper.VerifyPassword(command.Password, user.Password, user.Salf))
        {
            result.AddApiErrorMessage("Password is incorrect", [command.Username]);
            return Ok(result);
        }

        GenerateToken(user, out string accessToken, out string refreshToken, out MUserToken loginToken);

        result.Result = new
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken
        };

        _ = await _apiDbContext.AddAsync(loginToken);
        _ = await _apiDbContext.SaveChangesAsync();

        return Ok(result);
    }

    // Make GenerateToken an instance method
    private void GenerateToken(MUser user, out string accessToken, out string refreshToken, out MUserToken loginToken)
    {
        DateTime refreshExpirationTime = DateTime.UtcNow.AddMinutes(525960);
        MUserModel userModel = new(user.EntityId.ToString(), user.UserName, [user.Name]);

        accessToken = _authTokenHelper.GenerateAuthenticateToken(userModel, null);
        refreshToken = Guid.NewGuid().ToString();
        loginToken = new(user.Id, "System", "RefreshToken", accessToken, refreshExpirationTime);
    }

    private async Task<bool> UserIsExistAsync(string userName)
    {
        return await _apiDbContext.Users.AnyAsync(x => x.UserName == userName);
    }
}