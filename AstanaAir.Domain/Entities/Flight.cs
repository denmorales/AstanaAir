using System.ComponentModel.DataAnnotations;
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
    [MaxLength(256)]
    public string Origin { get; set; } = null!;
    /// <summary>
    /// Аэропорт прибытия.
    /// </summary>
    [MaxLength(256)]
    public string Destination { get; set; } = null!;
    /// <summary>
    /// Время отправления локальное.
    /// </summary>
    public DateTimeOffset Departure { get; set; }
    /// <summary>
    /// Время прибытия локальное.
    /// </summary>
    public DateTimeOffset Arrival { get; set; }
    /// <summary>
    /// Статус полета.
    /// </summary>
    public Status Status { get; set; }
}