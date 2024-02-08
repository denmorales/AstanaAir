using System.Security.Authentication;
using AstanaAir.Application.Common.Commands;
using AstanaAir.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Tests.Infrastructure;

namespace Tests
{
    public class AuthorizeCommandTests
    {
        private readonly ApplicationDbContext _context = new InMemoryContext(new DbContextOptions<ApplicationDbContext>());

        [SetUp]
        public void Setup()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
        }

        [Test]
        public async Task AuthorizeCommandHandler_Handle_Success()
        {
            var command = new AuthorizeCommand()
            {
                Password = "pass1",
                UserName = "user1"
            };
            var handler = new AuthorizeCommand.AuthorizeCommandHandler(_context);

            var token = await handler.Handle(command, CancellationToken.None);

            Assert.NotNull(token);
        }

        [Test]
        public async Task AuthorizeCommandHandler_Handle_Failed()
        {
            var command = new AuthorizeCommand()
            {
                Password = "notValidPassword",
                UserName = "user1"
            };
            var handler = new AuthorizeCommand.AuthorizeCommandHandler(_context);

           Assert.ThrowsAsync<AuthenticationException>(async () => await handler.Handle(command, CancellationToken.None));
        }
    }
}