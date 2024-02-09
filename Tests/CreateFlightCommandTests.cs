using System.Security.Authentication;
using AstanaAir.Application.Common.Commands;
using AstanaAir.Domain.Enum;
using AstanaAir.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Tests.Infrastructure;

namespace Tests;

public class CreateFlightCommandTests
{
    private readonly ApplicationDbContext _context = new InMemoryContext(new DbContextOptions<ApplicationDbContext>());

    [SetUp]
    public void Setup()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }

    [Test]
    public async Task CreateFlightCommandHandler_Handle_Success()
    {
        var command = new CreateFlightCommand()
        {
            Arrival = DateTime.Now + TimeSpan.FromHours(2),
            Departure = DateTime.Now + TimeSpan.FromHours(4),
            Destination = "Алматы",
            Origin = "Внуково",
            Status = Status.InTime
        };
        var handler = new CreateFlightCommandHandler(_context);

        var id = await handler.Handle(command, CancellationToken.None);

        Assert.NotNull(id);
    }
}