using AstanaAir.Domain.Entities;
using AstanaAir.Domain.Enum;
using AstanaAir.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Application.Common.Commands;

public record CreateFlightCommand : IRequest<int>
{
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }
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
        var originAirport = await _context.Airports
            .Where(i => i.Name == request.Origin)
            .FirstOrDefaultAsync(cancellationToken) ?? throw new InvalidDataException();
        var destinationAirport = await _context.Airports
            .Where(i => i.Name == request.Destination)
            .FirstOrDefaultAsync(cancellationToken) ?? throw new InvalidDataException();

        var entity = new Flight
        {
            Origin = request.Origin,
            Destination = request.Destination,
            Departure = new DateTimeOffset(request.Departure.ToUniversalTime(),TimeSpan.FromHours(originAirport.Offset)),
            Arrival = new DateTimeOffset(request.Arrival.ToUniversalTime(), TimeSpan.FromHours(destinationAirport.Offset)),
            Status = request.Status,
        };

        await _context.Flights.AddAsync(entity, cancellationToken);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
