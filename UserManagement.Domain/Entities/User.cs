using System.Collections.Generic;

namespace UserManagement.Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}