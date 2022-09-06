using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserManagement.Application.Models;
using UserManagement.Application.Services.Permissions.Queries.GetPermissionList;

namespace UserManagement.WebUI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PermissionController : BaseController
    {
        [HttpPost]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<ListModel<PermissionListModel>>> List([FromBody] GetPermissionListQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}