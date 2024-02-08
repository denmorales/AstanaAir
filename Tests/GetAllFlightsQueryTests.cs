using System.Security.Authentication;
using AstanaAir.Application.Common.Commands;
using AstanaAir.Application.Common.Queries;
using AstanaAir.Infrastructure;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tests.Infrastructure;

namespace Tests;

public class GetAllFlightsQueryTests
{
    private readonly ApplicationDbContext _context = new InMemoryContext(new DbContextOptions<ApplicationDbContext>());
    private IMapper _mapper;

    [SetUp]
    public void Setup()
    {
        var mappingConfig = new MapperConfiguration(mc => { });
        _mapper = mappingConfig.CreateMapper();
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }

    [Test]
    public async Task GetAllFlightsQueryHandler_Handle_Success()
    {
        var query = new GetAllFlightsQuery()
        {
            Destination = "Аэропорт1",
            Origin = "Аэропорт2"
        };
        var handler = new GetAllFlightsQueryHandler(_context, _mapper);

        var allFlights = await handler.Handle(query, CancellationToken.None);

        Assert.IsNotEmpty(allFlights);
    }

}