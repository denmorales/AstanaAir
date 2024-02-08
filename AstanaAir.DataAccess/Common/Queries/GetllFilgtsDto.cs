using AstanaAir.Domain.Enum;

namespace AstanaAir.Application.Common.Queries;

public class GetAllFlightsDto
{
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTimeOffset Departure { get; set; }
    public DateTimeOffset Arrival { get; set; }
    public Status Status { get; set; }
}