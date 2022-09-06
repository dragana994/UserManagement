using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Application.Common;
using UserManagement.Application.Exceptions;
using UserManagement.Application.Interfaces;

namespace UserManagement.Application.Services.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUserManagementDbContext _context;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUserManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var usernameExists = await _context.Users
                .AnyAsync(x => x.Username == request.Username, cancellationToken);

            if (usernameExists)
                throw new DomainValidationException("This username is already in use.");

            var user = _mapper.Map<Domain.Entities.User>(request);
            user.Password = PasswordHash.Create(request.Password);
            user.Active = true;

            await _context.Users.AddAsync(user, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return user.Id;
        }
    }
}