using AstanaAir.Application.Common.Commands;
using AstanaAir.Domain.Enum;
using AstanaAir.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Tests.Infrastructure;

namespace Tests;

public class EditFlightCommandTests
{
    private readonly ApplicationDbContext _context = new InMemoryContext(new DbContextOptions<ApplicationDbContext>());

    [SetUp]
    public void Setup()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();
    }

    [Test]
    public async Task EditFlightCommandHandler_Handle_Success()
    {
        var command = new EditFlightCommand()
        {
            FlightId = 1002,
            Status = Status.InTime
        };

        var handler = new EditFlightCommandHandler(_context);

        await handler.Handle(command, CancellationToken.None);

        var flight = await _context.Flights.Where(i => i.Id == 1002).FirstOrDefaultAsync();

        Assert.AreEqual(flight!.Status, command.Status);
    }
}