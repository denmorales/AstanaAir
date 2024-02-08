using System.ComponentModel.DataAnnotations;

namespace AstanaAir.Domain.Entities;

public class Role
{
    /// <summary>
    /// Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Код роли.
    /// </summary>
    [MaxLength(256)]
    public string Code { get; set; } = null!;
    /// <summary>
    /// Список пользователей
    /// </summary>
    public IEnumerable<User> Users { get; set; } = null!;
}