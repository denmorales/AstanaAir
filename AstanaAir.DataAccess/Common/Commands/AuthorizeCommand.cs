using System.IdentityModel.Tokens.Jwt;
using System.Security.Authentication;
using System.Security.Claims;
using AstanaAir.Domain.Authorization;
using AstanaAir.Domain.Entities;
using AstanaAir.Domain.Extentions;
using AstanaAir.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AstanaAir.Application.Common.Commands;

public record AuthorizeCommand : IRequest<string>
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;

    public class AuthorizeCommandHandler : IRequestHandler<AuthorizeCommand, string>
    {
        private readonly ApplicationDbContext _context;

        public AuthorizeCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AuthorizeCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Include(r => r.Role)
                .Where(u => u.UserName == request.UserName)
                .FirstOrDefaultAsync(cancellationToken);
            return user != null && user.PasswordIsValid(request.Password)
                ? CreateJwtToken(user)
                : throw new AuthenticationException("Invalid UserName or Password");
        }

        private static string CreateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, user.UserName),
                new(ClaimTypes.Role, user.Role.Code)
            };
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.Issuer,
                audience: AuthOptions.Audience,
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(60)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
