using System.Reflection;
using AstanaAir.Application.Consts;
using AstanaAir.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Infrastructure;

public class ApplicationDbContext : DbContext
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

        builder.Entity<User>()
            .HasData(new[]
            {
                new User()
                {
                    Id = 1,
                    Password = "pass1",
                    RoleId = RoleIds.User,
                    UserName = "user1"
                },
                new User()
                {
                    Id = 2,
                    Password = "pass2",
                    RoleId = RoleIds.Moderator,
                    UserName = "moderator1"
                }
            });

        builder.Entity<Role>()
            .HasData(new[]
            {
                new Role()
                {
                    Id = RoleIds.User,
                    Code = nameof(RoleIds.User)
                },
                new Role()
                {
                    Id = RoleIds.Moderator,
                    Code = nameof(RoleIds.Moderator)
                },
            });

        base.OnModelCreating(builder);
    }
}
