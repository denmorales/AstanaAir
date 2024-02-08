using AstanaAir.Infrastructure;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Application.Common.Queries;

public record GetAllFlightsQuery : IRequest<List<GetAllFlightsDto>>
{
    public string? Origin { get; init; }
    public string? Destination { get; init; }
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
        var query = _context.Flights.AsQueryable();

        if (!string.IsNullOrEmpty(request.Origin))
        {
            query = query.Where(o => o.Origin == request.Origin);
        }

        if (!string.IsNullOrEmpty(request.Destination))
        {
            query = query.Where(o => o.Destination == request.Destination);
        }

        var flights = await query
            .OrderBy(x => x.Arrival)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
        return _mapper.Map<List<GetAllFlightsDto>>(flights);
    }
}
