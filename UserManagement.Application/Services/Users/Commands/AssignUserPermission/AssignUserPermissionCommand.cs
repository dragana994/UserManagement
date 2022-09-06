using MediatR;
using System.Collections.Generic;

namespace UserManagement.Application.Services.Users.Commands.AssignUserPermission
{
    public class AssignUserPermissionCommand : IRequest<Unit>
    {
        public int UserId { get; set; }
        public List<int> PermissionIds { get; set; }
    }
}