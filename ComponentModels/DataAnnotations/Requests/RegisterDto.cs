namespace API.ComponentModels.DataAnnotations.Requests;

public class RegisterDto
{
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public required string EmailAddress { get; set; }

    public required string UserName { get; set; }
    public required string Password { get; set; }
}