using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker.Application.Services;

namespace TimeTracker.Application
{
    public static class AddDepndencies
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();

            return services;
        }
    }
}
