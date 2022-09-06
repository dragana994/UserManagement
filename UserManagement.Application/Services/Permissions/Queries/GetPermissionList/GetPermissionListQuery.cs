using MediatR;
using UserManagement.Application.Models;

namespace UserManagement.Application.Services.Permissions.Queries.GetPermissionList
{
    public class GetPermissionListQuery : BaseListQuery, IRequest<ListModel<PermissionListModel>>
    {
        public int UserId { get; set; }
        public bool DetailMode { get; set; }
    }
}