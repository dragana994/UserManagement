using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Application.Services.Users.Commands.CreateUser;
using Xunit;

namespace UserManagement.Application.Tests.Tests.Services.Users
{
    public class CreateUserTests : TestBase
    {
        [Fact]
        public async Task CreateUser_ShouldCreate()
        {
            var command = new CreateUserCommand
            {
                FirstName = "FirstName test",
                LastName = "LastName test",
                Username = "Username test",
                Password = "Password test",
                Email = "test@gmail.com"
            };

            var commandHandler = new CreateUserCommandHandler(InMemoryContext, FakeMapper);

            var result = await commandHandler.Handle(command, CancellationToken.None);

            result.ShouldBeOfType<int>();
        }
    }
}