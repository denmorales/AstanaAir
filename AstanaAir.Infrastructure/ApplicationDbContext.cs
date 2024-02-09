using System.Reflection;
using AstanaAir.Application.Consts;
using AstanaAir.Domain.Entities;
using AstanaAir.Domain.Enum;
using AstanaAir.Domain.Extentions;
using Microsoft.EntityFrameworkCore;

namespace AstanaAir.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Flight> Flights => Set<Flight>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Airport> Airports => Set<Airport>();

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

        #region UserDataSeed
        builder.Entity<User>()
            .HasData(
                new User
                {
                    Id = 1,
                    RoleId = RoleIds.User,
                    UserName = "user1"
                }.HashPassword("pass1"),
                new User
                {
                    Id = 2,
                    RoleId = RoleIds.Moderator,
                    UserName = "moderator1"
                }.HashPassword("pass2"));
        #endregion

        builder.Entity<Role>()
            .HasIndex(x => x.Code)
            .IsUnique();

        #region RoleDataSeed
        builder.Entity<Role>()
            .HasData(new Role
            {
                Id = RoleIds.User,
                Code = nameof(RoleIds.User)
            }, new Role
            {
                Id = RoleIds.Moderator,
                Code = nameof(RoleIds.Moderator)
            });
        #endregion

        #region FlightDataSeed
        builder.Entity<Flight>()
            .HasData(new Flight
                {
                    Id = 1000,
                    Origin = "Аэропорт1",
                    Arrival = DateTimeOffset.Now,
                    Departure = DateTimeOffset.Now + TimeSpan.FromHours(12),
                    Destination = "Аэропорт2",
                    Status = Status.InTime
                }, new Flight
                {
                    Id = 1001,
                    Origin = "Аэропорт3",
                    Arrival = DateTimeOffset.Now,
                    Departure = DateTimeOffset.Now + TimeSpan.FromHours(12),
                    Destination = "Аэропорт4",
                    Status = Status.Cancelled
                }, new Flight
                {
                    Id = 1002,
                    Origin = "Внуково",
                    Arrival = DateTimeOffset.Now,
                    Departure = DateTimeOffset.Now + TimeSpan.FromHours(16),
                    Destination = "Магадан",
                    Status = Status.InTime
                },
                new Flight
                {
                    Id = 1003,
                    Origin = "Екатеринбург",
                    Arrival = DateTimeOffset.Now,
                    Departure = DateTimeOffset.Now + TimeSpan.FromHours(2),
                    Destination = "Алматы",
                    Status = Status.InTime
                });
        #endregion

        #region AirportsDataSeed
        builder.Entity<Airport>()
            .HasData(new Airport
            {
                Id = 1,
                Code = "VNK",
                Name = "Внуково",
                Offset = 3,
            }, new Airport
            {
                Id = 2,
                Code = "EKB",
                Name = "Екатеринбург",
                Offset = 5
            }, new Airport
            {
                Id = 3,
                Code = "SRT",
                Name = "Саратов",
                Offset = 4
            }, new Airport
            {
                Id = 4,
                Code = "ALM",
                Name = "Алматы",
                Offset = 6
            }, new Airport
            {
                Id = 5,
                Code = "MGD",
                Name = "Магадан",
                Offset = 11
            });
        #endregion

        base.OnModelCreating(builder);
    }
}
