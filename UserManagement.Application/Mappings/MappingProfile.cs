using AutoMapper;
using UserManagement.Application.Services.Users.Commands.CreateUser;
using UserManagement.Application.Services.Users.Queries.GetUserDetails;
using UserManagement.Application.Services.Users.Queries.GetUserList;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserCommand, User>();
            CreateMap<User, UserModel>();
            CreateMap<User, UserListModel>();
        }
    }
}