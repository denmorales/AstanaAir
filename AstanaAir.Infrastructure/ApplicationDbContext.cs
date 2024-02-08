using System.Reflection;
using AstanaAir.Application.Consts;
using AstanaAir.Domain.Entities;
using AstanaAir.Domain.Extentions;
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
            .HasIndex(x => x.UserName)
            .IsUnique();

        builder.Entity<User>()
            .HasData(
                new User()
                {
                    Id = 1,
                    RoleId = RoleIds.User,
                    UserName = "user1"
                }.HashPassword("pass1"),
                new User()
                {
                    Id = 2,
                    RoleId = RoleIds.Moderator,
                    UserName = "moderator1"
                }.HashPassword("pass2"));

        builder.Entity<Role>()
            .HasIndex(x => x.Code)
            .IsUnique();

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
