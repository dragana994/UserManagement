using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Application.Exceptions;
using UserManagement.Application.Interfaces;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Services.Users.Commands.AssignUserPermission
{
    public class AssignUserPermissionCommandHandler : IRequestHandler<AssignUserPermissionCommand, Unit>
    {
        private readonly IUserManagementDbContext _context;

        public AssignUserPermissionCommandHandler(IUserManagementDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(AssignUserPermissionCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Include(x => x.UserPermissions)
                .SingleOrDefaultAsync(x => x.Id == request.UserId, cancellationToken);

            if (user == null)
            {
                throw new NotFoundException(nameof(User), request.UserId);
            }

            _context.UserPermissions.RemoveRange(user.UserPermissions);

            request.PermissionIds.ForEach(id =>
            {
                user.UserPermissions.Add(new UserPermission
                {
                    PermissionId = id
                });
            });

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}