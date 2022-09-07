﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UserManagement.Infrastructure.Persistence;

namespace UserManagement.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(UserManagementDbContext))]
    [Migration("20220907171957_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("UserManagement.Domain.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "V125",
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 641, DateTimeKind.Local).AddTicks(5807),
                            Description = "View"
                        },
                        new
                        {
                            Id = 2,
                            Code = "C125",
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 644, DateTimeKind.Local).AddTicks(4333),
                            Description = "Create"
                        },
                        new
                        {
                            Id = 3,
                            Code = "D125",
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 644, DateTimeKind.Local).AddTicks(4372),
                            Description = "Delete"
                        },
                        new
                        {
                            Id = 4,
                            Code = "E525",
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 644, DateTimeKind.Local).AddTicks(4378),
                            Description = "Edit"
                        });
                });

            modelBuilder.Entity("UserManagement.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1415),
                            Email = "zdunlap0@comsenz.com",
                            FirstName = "Zsa zsa",
                            LastName = "Dunlap",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "zdunlap0"
                        },
                        new
                        {
                            Id = 101,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1465),
                            Email = "tsnedker1@ucsd.edu",
                            FirstName = "Thatch",
                            LastName = "Snedker",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "tsnedker1"
                        },
                        new
                        {
                            Id = 102,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1470),
                            Email = "mobispo2@etsy.com",
                            FirstName = "Mill",
                            LastName = "Obispo",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "mobispo2"
                        },
                        new
                        {
                            Id = 103,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1476),
                            Email = "kboutwell3@squarespace.com",
                            FirstName = "Kacy",
                            LastName = "Boutwell",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "kboutwell3"
                        },
                        new
                        {
                            Id = 104,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1481),
                            Email = "tfellibrand4@csmonitor.com",
                            FirstName = "Thornie",
                            LastName = "Fellibrand",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "tfellibrand4"
                        },
                        new
                        {
                            Id = 105,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1486),
                            Email = "hpodd5@freewebs.com",
                            FirstName = "Hy",
                            LastName = "Podd",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "hpodd5"
                        },
                        new
                        {
                            Id = 106,
                            Active = false,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1492),
                            Email = "rcreeghan6@mashable.com",
                            FirstName = "Reba",
                            LastName = "Creeghan",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "rcreeghan6"
                        },
                        new
                        {
                            Id = 107,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1497),
                            Email = "kturnbull7@buzzfeed.com",
                            FirstName = "Kinnie",
                            LastName = "Turnbull",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "kturnbull7"
                        },
                        new
                        {
                            Id = 108,
                            Active = false,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1503),
                            Email = "lmaunders8@histats.com",
                            FirstName = "Luis",
                            LastName = "Maunders",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "lmaunders8"
                        },
                        new
                        {
                            Id = 109,
                            Active = false,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1508),
                            Email = "estreetfield9@typepad.com",
                            FirstName = "Edeline",
                            LastName = "Streetfield",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "estreetfield9"
                        },
                        new
                        {
                            Id = 110,
                            Active = false,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1513),
                            Email = "lmegroffa@dell.com",
                            FirstName = "Lulu",
                            LastName = "Megroff",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "lmegroffa"
                        },
                        new
                        {
                            Id = 111,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1578),
                            Email = "cjopeb@walmart.com",
                            FirstName = "Carlotta",
                            LastName = "Jope",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "cjopeb"
                        },
                        new
                        {
                            Id = 112,
                            Active = true,
                            Created = new DateTime(2022, 9, 7, 19, 19, 56, 648, DateTimeKind.Local).AddTicks(1585),
                            Email = "ljosephyc@mapquest.com",
                            FirstName = "Lyndsey",
                            LastName = "Josephy",
                            Password = "jglJ6PUzNYl+X9/qjbHIbImU8mYj/811l/0lTljVd4k=",
                            Username = "ljosephyc"
                        });
                });

            modelBuilder.Entity("UserManagement.Domain.Entities.UserPermission", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("UserManagement.Domain.Entities.UserPermission", b =>
                {
                    b.HasOne("UserManagement.Domain.Entities.Permission", "Permission")
                        .WithMany("UserPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UserManagement.Domain.Entities.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserManagement.Domain.Entities.Permission", b =>
                {
                    b.Navigation("UserPermissions");
                });

            modelBuilder.Entity("UserManagement.Domain.Entities.User", b =>
                {
                    b.Navigation("UserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
