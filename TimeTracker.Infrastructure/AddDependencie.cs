using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TimeTracker.Domain.Repository;
using TimeTracker.Infrastructure.DAL.InMemory;

namespace TimeTracker.Infrastructure
{
    public static class AddDependencie
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton<ITestRepo, TestRepo>();
            services.AddSingleton<IUserRepository, UserRepository>();
            return services;
        }
    }
}
