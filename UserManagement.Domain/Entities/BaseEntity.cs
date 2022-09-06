using System;

namespace UserManagement.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
    }
}