using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagement.Domain.Entities;

namespace UserManagement.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(u => u.Username)
                .IsUnique();

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Email)
                .HasMaxLength(100);

            builder.HasData(
                new User
                {
                    Id = 100,
                    FirstName = "Zsa zsa",
                    LastName = "Dunlap",
                    Username = "zdunlap0",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "zdunlap0@comsenz.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 101,
                    FirstName = "Thatch",
                    LastName = "Snedker",
                    Username = "tsnedker1",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "tsnedker1@ucsd.edu",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 102,
                    FirstName = "Mill",
                    LastName = "Obispo",
                    Username = "mobispo2",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "mobispo2@etsy.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 103,
                    FirstName = "Kacy",
                    LastName = "Boutwell",
                    Username = "kboutwell3",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "kboutwell3@squarespace.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 104,
                    FirstName = "Thornie",
                    LastName = "Fellibrand",
                    Username = "tfellibrand4",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "tfellibrand4@csmonitor.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 105,
                    FirstName = "Hy",
                    LastName = "Podd",
                    Username = "hpodd5",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "hpodd5@freewebs.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 106,
                    FirstName = "Reba",
                    LastName = "Creeghan",
                    Username = "rcreeghan6",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "rcreeghan6@mashable.com",
                    Active = false,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 107,
                    FirstName = "Kinnie",
                    LastName = "Turnbull",
                    Username = "kturnbull7",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "kturnbull7@buzzfeed.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 108,
                    FirstName = "Luis",
                    LastName = "Maunders",
                    Username = "lmaunders8",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "lmaunders8@histats.com",
                    Active = false,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 109,
                    FirstName = "Edeline",
                    LastName = "Streetfield",
                    Username = "estreetfield9",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "estreetfield9@typepad.com",
                    Active = false,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 110,
                    FirstName = "Lulu",
                    LastName = "Megroff",
                    Username = "lmegroffa",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "lmegroffa@dell.com",
                    Active = false,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 111,
                    FirstName = "Carlotta",
                    LastName = "Jope",
                    Username = "cjopeb",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "cjopeb@walmart.com",
                    Active = true,
                    Created = DateTime.Now
                },
                new User
                {
                    Id = 112,
                    FirstName = "Lyndsey",
                    LastName = "Josephy",
                    Username = "ljosephyc",
                    Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                    Email = "ljosephyc@mapquest.com",
                    Active = true,
                    Created = DateTime.Now
                }
            );
        }
    }
}