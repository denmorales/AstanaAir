using AstanaAir.Application.Common.Queries;
using AstanaAir.Infrastructure;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Tests.Infrastructure;
using Profile = DataAccess.Mapping.Profile;

namespace Tests;

public class GetAllFlightsQueryTests
{
    private readonly ApplicationDbContext _context = new InMemoryContext(new DbContextOptions<ApplicationDbContext>());
    private IMapper _mapper;

    [SetUp]
    public void Setup()
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new Profile());
        });
        _mapper = mappingConfig.CreateMapper();
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }

    [Test]
    public async Task GetAllFlightsQueryHandler_Handle_Success()
    {
        var query = new GetAllFlightsQuery()
        {
            Destination = "��������2",
            Origin = "��������1"
        };
        var handler = new GetAllFlightsQueryHandler(
            _context,
            _mapper,
            new MemoryCache(new OptionsWrapper<MemoryCacheOptions>(new MemoryCacheOptions())));

        var allFlights = await handler.Handle(query, CancellationToken.None);

        Assert.IsNotEmpty(allFlights);
    }
}