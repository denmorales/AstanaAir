using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AstanaAir.Domain.Authorization;
public class AuthOptions
{
    public const string Issuer = "AstanaAirServer"; // издатель токена
    public const string Audience = "AstanaAirClient"; // потребитель токена
    const string Key = "mysupersecret_secretsecretsecretkey!123";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.UTF8.GetBytes(Key));
}