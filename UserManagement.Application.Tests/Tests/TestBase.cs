using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using UserManagement.Application.Mappings;
using UserManagement.Infrastructure.Persistence;

namespace UserManagement.Application.Tests.Tests
{
    public class TestBase
    {
        public IMapper FakeMapper { get; }
        private UserManagementDbContext _inMemoryContext;

        public TestBase()
        {
            FakeMapper = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            }).CreateMapper();
        }

        public UserManagementDbContext InMemoryContext
        {
            get
            {
                var inMemoryContextOptions = new DbContextOptionsBuilder<UserManagementDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .ConfigureWarnings(x => x.Ignore(InMemoryEventId.TransactionIgnoredWarning))
                    .Options;

                return new UserManagementDbContext(inMemoryContextOptions);
            }
        }
    }
}