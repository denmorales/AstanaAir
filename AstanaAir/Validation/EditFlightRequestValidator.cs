using AstanaAir.Domain.Models;
using FluentValidation;

namespace AstanaAir.Web.Validation;

/// <summary>
/// Валидация запроса редактирования статуса рейса.
/// </summary>
public class EditFlightRequestValidator : AbstractValidator<EditFlightRequest>
{
    public EditFlightRequestValidator()
    {
        RuleFor(x => x.Status)
            .NotNull();
    }
}