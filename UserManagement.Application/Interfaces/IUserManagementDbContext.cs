using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using UserManagement.Domain.Entities;

namespace UserManagement.Application.Interfaces
{
    public interface IUserManagementDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        public DbSet<User> Users { get; }
        public DbSet<Permission> Permissions { get; }
        public DbSet<UserPermission> UserPermissions { get; }

    }
}