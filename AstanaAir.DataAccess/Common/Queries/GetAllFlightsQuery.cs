using AstanaAir.Infrastructure;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Application.Common.Queries;

public record GetAllFlightsQuery : IRequest<List<GetAllFlightsDto>>
{
    public string Origin { get; init; } = String.Empty;
    public string Destination { get; init; } = String.Empty;
}

public class GetAllFlightsQueryHandler : IRequestHandler<GetAllFlightsQuery, List<GetAllFlightsDto>>
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllFlightsQueryHandler(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<GetAllFlightsDto>> Handle(GetAllFlightsQuery request, CancellationToken cancellationToken)
    {
        var flights = await _context.Flights
            .Where(o => o.Origin == request.Origin)
            .Where(o => o.Destination == request.Destination)
            .OrderBy(x => x.Arrival)
            .ToListAsync(cancellationToken);
        return _mapper.Map<List<GetAllFlightsDto>>(flights);
    }
}
