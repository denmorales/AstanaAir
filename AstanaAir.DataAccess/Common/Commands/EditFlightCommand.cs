using AstanaAir.Domain.Enum;
using AstanaAir.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Application.Common.Commands;

public record EditFlightCommand : IRequest
{
    public int FlightId { get; set; }
    public Status Status { get; set; }
}

public class EditFlightCommandHandler : IRequestHandler<EditFlightCommand>
{
    private readonly ApplicationDbContext _context;

    public EditFlightCommandHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(EditFlightCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Flights
            .Where(f => f.Id == request.FlightId)
            .FirstOrDefaultAsync(cancellationToken);

        entity!.Status = request.Status;

        await _context.SaveChangesAsync(cancellationToken);
    }
}
