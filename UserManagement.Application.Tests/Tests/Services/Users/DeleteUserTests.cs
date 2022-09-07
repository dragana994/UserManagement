using System.Threading;
using System.Threading.Tasks;
using UserManagement.Application.Exceptions;
using UserManagement.Application.Services.Users.Commands.DeleteUser;
using Xunit;

namespace UserManagement.Application.Tests.Tests.Services.Users
{
    public class DeleteUserTests : TestBase
    {
        [Fact]
        public async Task DeleteUser_ShouldNotDelete()
        {
            var command = new DeleteUserCommand
            {
                Id = 100
            };

            var commandHandler = new DeleteUserCommandHandler(InMemoryContext);

            await Assert.ThrowsAsync<NotFoundException>(() => commandHandler.Handle(command, CancellationToken.None));
        }
    }
}