using AstanaAir.Domain.Enum;

namespace AstanaAir.Domain.Models;

public class CreateFlightRequest
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTimeOffset Departure { get; set; }
    public DateTimeOffset Arrival { get; set; }
    public Status Status { get; set; }
}