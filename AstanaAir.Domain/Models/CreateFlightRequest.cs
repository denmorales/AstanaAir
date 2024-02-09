using AstanaAir.Domain.Enum;

namespace AstanaAir.Domain.Models;

public class CreateFlightRequest
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime Departure { get; set; }
    public DateTime Arrival { get; set; }
    public Status Status { get; set; }
}