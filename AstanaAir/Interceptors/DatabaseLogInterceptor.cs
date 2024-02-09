using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace AstanaAir.Web.Interceptors;

/// <summary>
/// Перехватчик логов изменения в базе данных
/// </summary>
public class DatabaseLogInterceptor : SaveChangesInterceptor
{
    private readonly ILogger<DatabaseLogInterceptor> _logger;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public DatabaseLogInterceptor(
        ILogger<DatabaseLogInterceptor> logger,
        IHttpContextAccessor httpContextAccessor)
    {
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result,
        CancellationToken cancellationToken = new())
    {
        var userName = _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "Неизвестный пользователь";
        var changedEntries = eventData.Context.ChangeTracker.Entries()
            .Where(en => en.State == EntityState.Added
                         || en.State == EntityState.Modified
                         || en.State == EntityState.Deleted);
        foreach (var changedEntry in changedEntries)
        {
            var action = changedEntry.State switch
            {
                EntityState.Added => "Добавлена",
                EntityState.Deleted => "Удалена",
                EntityState.Modified => "Изменена",
                _ => string.Empty,
            };
            var changes = $"Пользователь {userName} в {DateTime.Now:f} произвел изменения в базе данных: {action} сущность {changedEntry.GetType().Name}";
            var hasChanges = true;
            if (changedEntry.State == EntityState.Modified)
            {
                var modifications = VerboseModifications(changedEntry);
                hasChanges = !string.IsNullOrWhiteSpace(modifications);
                changes = $"{changes} : изменены {modifications}";
            }

            if (hasChanges)
            {
                _logger.LogInformation(changes);
            }
        }

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    /// <summary>
    /// Verboses the modifications.
    /// </summary>
    /// <param name="changedEntry">The changed entry.</param>
    /// <returns></returns>
    private static string VerboseModifications(EntityEntry changedEntry)
    {
        var modifications = new List<string>();
        foreach (var entry in changedEntry.Properties.Where(p => p.IsModified && p.OriginalValue != p.CurrentValue))
        {
            if (entry.Metadata.PropertyInfo != null)
            {
                var original = entry.OriginalValue?.ToString();
                var current = entry.CurrentValue?.ToString();
                if (!string.Equals(original, current, StringComparison.OrdinalIgnoreCase))
                {
                    var displayAttribute =
                        entry.Metadata.PropertyInfo.CustomAttributes.FirstOrDefault(ca =>
                            ca.AttributeType == typeof(DisplayAttribute));
                    var name = displayAttribute?.NamedArguments?.FirstOrDefault().TypedValue.ToString() ?? entry.Metadata.Name;
                    var modification = $"{name} с {original} на {current}";
                    modifications.Add(modification);
                }
            }
        }

        var result = modifications.Count > 0 ? string.Join(",", modifications) : string.Empty;
        return result;
    }
}