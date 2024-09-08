namespace API.Repository;
public class UserRepository(ApiDbContext dbContext, MAuthenticateInfoContext authContext) : MRepository<MUser>(dbContext, authContext), IUserRepository
{
}
