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
    public string UserName { get; set; } = null!;
    /// <summary>
    /// Пароль пользователя.
    /// </summary>
    public string Password { get; set; } = null!;
    /// <summary>
    /// Id роли.
    /// </summary>
    public int RoleId { get; set; }
    /// <summary>
    /// Роль.
    /// </summary>
    public Role Role { get; set; }
}