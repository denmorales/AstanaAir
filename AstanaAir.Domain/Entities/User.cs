using System.ComponentModel.DataAnnotations;

namespace AstanaAir.Domain.Entities;

public class User
{
    /// <summary>
    /// Id.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    [MaxLength(256)]
    public string UserName { get; set; } = null!;
    /// <summary>
    /// Id роли.
    /// </summary>
    public int RoleId { get; set; }
    /// <summary>
    /// Роль.
    /// </summary>
    public Role Role { get; set; }
    /// <summary>
    /// Хэш пароля.
    /// </summary>
    public string Hash { get; set; } = null!;
    /// <summary>
    /// Соль.
    /// </summary>
    public byte[] Salt { get; set; } = null!;
}