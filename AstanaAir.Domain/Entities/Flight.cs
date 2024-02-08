using AstanaAir.Domain.Enum;

namespace AstanaAir.Domain.Entities;

public class Flight
{
    /// <summary>
    /// Id.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Aэропорт отправления.
    /// </summary>
    public string Origin { get; set; } = null!;
    /// <summary>
    /// Аэропорт прибытия.
    /// </summary>
    public string Destination { get; set; } = null!;
    /// <summary>
    /// Время отправления.
    /// </summary>
    public DateTimeOffset Departure { get; set; }
    /// <summary>
    /// Время прибытия.
    /// </summary>
    public DateTimeOffset Arrival { get; set; }
    /// <summary>
    /// Статус полета.
    /// </summary>
    public Status Status { get; set; }
}