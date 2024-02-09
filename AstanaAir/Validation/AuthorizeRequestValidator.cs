using AstanaAir.Domain.Models;
using FluentValidation;

namespace AstanaAir.Web.Validation;

/// <summary>
/// Валидация запроса авторизации.
/// </summary>
public class AuthorizeRequestValidator : AbstractValidator<AuthorizeRequest>
{
    public AuthorizeRequestValidator()
    {
        RuleFor(x => x.Password)
            .NotEmpty()
            .MaximumLength(40)
            .WithMessage("Title cannot exceed 40 characters");
        RuleFor(x => x.UserName)
            .NotEmpty()
            .MaximumLength(40)
            .WithMessage("The body of the post cannot exceed 40 characters");
    }
}