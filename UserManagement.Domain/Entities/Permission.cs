using System.Collections.Generic;

namespace UserManagement.Domain.Entities
{
    public class Permission : BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}