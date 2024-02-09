namespace AstanaAir.Domain.Models;

public class AuthorizeRequest
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
}