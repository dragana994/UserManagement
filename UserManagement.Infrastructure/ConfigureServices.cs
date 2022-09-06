using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Application.Interfaces;
using UserManagement.Infrastructure.Persistence;

namespace UserManagement.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserManagementDbContext>(
                opts =>
                {
                    opts.UseNpgsql(configuration.GetConnectionString("UserManagementDb"));
                });

            services.AddScoped<IUserManagementDbContext>(provider => provider.GetRequiredService<UserManagementDbContext>());

            return services;
        }
    }
}