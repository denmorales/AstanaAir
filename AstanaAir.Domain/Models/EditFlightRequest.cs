using AstanaAir.Domain.Enum;

namespace AstanaAir.Domain.Models;

public class EditFlightRequest
{
    public int Id { get; set; }
    public Status Status { get; set; }
}