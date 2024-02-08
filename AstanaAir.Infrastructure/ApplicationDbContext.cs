using System.Reflection;
using AstanaAir.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Infrastructure;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Flight> Flights => Set<Flight>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<User> Users => Set<User>();

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<Enum>().HaveConversion<string>();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<User>()
            .HasOne(e => e.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(k => k.RoleId);

        base.OnModelCreating(builder);
    }
}
