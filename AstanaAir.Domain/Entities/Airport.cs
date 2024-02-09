namespace AstanaAir.Domain.Entities;

public class Airport
{
    /// <summary>
    /// Id аэропорта
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Название аэропорта.
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Код аэропорта.
    /// </summary>
    public string Code { get; set; } = null!;
    /// <summary>
    /// Часовой пояс.
    /// </summary>
    public short Offset { get; set; }
}