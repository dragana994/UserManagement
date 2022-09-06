using MediatR;

namespace UserManagement.Application.Services.Users.Queries.GetUserDetails
{
    public class GetUserDetailsQuery : IRequest<UserModel>
    {
        public int Id { get; set; }
    }
}