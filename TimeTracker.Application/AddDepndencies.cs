using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using TimeTracker.Application.User;

namespace TimeTracker.Application
{
    public static class AddDepndencies
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserQuery, UserQuery>();

            return services;
        }
    }
}
