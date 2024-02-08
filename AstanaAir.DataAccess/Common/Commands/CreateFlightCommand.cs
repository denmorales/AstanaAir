using AstanaAir.Domain.Entities;
using AstanaAir.Domain.Enum;
using AstanaAir.Infrastructure;
using MediatR;

namespace AstanaAir.Application.Common.Commands;

public record CreateFlightCommand : IRequest<int>
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTimeOffset Departure { get; set; }
    public DateTimeOffset Arrival { get; set; }
    public Status Status { get; set; }
}

public class CreateFlightCommandHandler : IRequestHandler<CreateFlightCommand, int>
{
    private readonly ApplicationDbContext _context;

    public CreateFlightCommandHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateFlightCommand request, CancellationToken cancellationToken)
    {
        var entity = new Flight()
        {
            Origin = request.Origin,
            Destination = request.Destination,
            Departure = request.Departure,
            Arrival = request.Arrival,
            Status = request.Status,
        };

        await _context.Flights.AddAsync(entity, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
