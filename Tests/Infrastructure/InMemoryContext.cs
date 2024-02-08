using AstanaAir.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Tests.Infrastructure;

public class InMemoryContext : ApplicationDbContext
{
    public InMemoryContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("TestBase");
    }
}