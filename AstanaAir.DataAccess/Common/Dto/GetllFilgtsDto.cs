using AstanaAir.Domain.Enum;

namespace AstanaAir.Application.Common.Dto;

public class GetAllFlightsDto
{
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public DateTimeOffset Departure { get; set; }
    public DateTimeOffset Arrival { get; set; }
    public Status Status { get; set; }
}