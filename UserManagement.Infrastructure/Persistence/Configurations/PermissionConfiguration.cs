using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagement.Domain.Entities;

namespace UserManagement.Infrastructure.Persistence.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasData(
                new Permission
                {
                    Id = 1,
                    Code = "V125",
                    Description = "View",
                    Created = System.DateTime.Now
                }, new Permission
                {
                    Id = 2,
                    Code = "C125",
                    Description = "Create",
                    Created = System.DateTime.Now
                }, new Permission
                {
                    Id = 3,
                    Code = "D125",
                    Description = "Delete",
                    Created = System.DateTime.Now
                }, new Permission
                {
                    Id = 4,
                    Code = "E525",
                    Description = "Edit",
                    Created = System.DateTime.Now
                }
            );
        }
    }
}