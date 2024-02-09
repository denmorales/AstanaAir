using AstanaAir.Domain.Models;
using FluentValidation;

namespace AstanaAir.Web.Validation;

/// <summary>
/// Валидация запрос добавления нового рейса.
/// </summary>
public class CreateFligtsValidator : AbstractValidator<CreateFlightRequest>
{
    public CreateFligtsValidator()
    {
        RuleFor(x => x.Origin)
            .NotEmpty()
            .MaximumLength(24)
            .WithMessage("Title cannot exceed 24 characters");
        RuleFor(x => x.Destination)
            .NotEmpty()
            .MaximumLength(24)
            .WithMessage("The body of the post cannot exceed 24 characters");
        RuleFor(x => x.Arrival)
            .Must(BeAValidDate)
            .WithMessage("Arrival date is required");
        RuleFor(x => x.Departure)
            .Must(BeAValidDate)
            .WithMessage("Departure date is required");
        RuleFor(x => x.Status)
            .NotNull();
    }
    private static bool BeAValidDate(DateTimeOffset date)
    {
        return !date.Equals(default);
    }
}