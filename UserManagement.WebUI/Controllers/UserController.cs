using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserManagement.Application.Models;
using UserManagement.Application.Services.Users.Commands.AssignUserPermission;
using UserManagement.Application.Services.Users.Commands.CreateUser;
using UserManagement.Application.Services.Users.Commands.DeleteUser;
using UserManagement.Application.Services.Users.Commands.UpdateUser;
using UserManagement.Application.Services.Users.Queries.GetUserDetails;
using UserManagement.Application.Services.Users.Queries.GetUserList;

namespace UserManagement.WebUI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Details(int id)
        {
            return Ok(await Mediator.Send(new GetUserDetailsQuery() { Id = id }));
        }

        [HttpPost]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ListModel<UserListModel>>> List([FromBody] GetUserListQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Assign([FromBody] AssignUserPermissionCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteUserCommand { Id = id });

            return NoContent();
        }
    }
}