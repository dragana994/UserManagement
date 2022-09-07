using MediatR;
using UserManagement.Application.Models;

namespace UserManagement.Application.Services.Users.Queries.GetUserList
{
    public class GetUserListQuery : BaseListQuery, IRequest<ListModel<UserListModel>>
    {
        public string SearchQuery { get; set; }
    }
}