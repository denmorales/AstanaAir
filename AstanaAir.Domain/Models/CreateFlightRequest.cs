using AstanaAir.Domain.Enum;

namespace AstanaAir.Domain.Models;

public class CreateFlightRequest
{
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }
    public Status Status { get; set; }
}