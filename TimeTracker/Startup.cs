using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TimeTracker.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using TimeTracker.Application;
using TimeTracker.Infrastructure.DAL.InMemory;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TimeTracker
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContextPool<Context_TimeTracker>(options => options.UseInMemoryDatabase(databaseName: "Add_writes_to_database"));
            var options = new DbContextOptionsBuilder<Context_TimeTracker>()
                .UseInMemoryDatabase(databaseName: "Add_writes_to_database").Options;
            var a = new Context_TimeTracker(options);
            services.AddSingleton(a);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddApplication();
            services.AddInfrastructure(_configuration);
            services.AddControllersWithViews();

            services.AddSwaggerGen();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    context.Response.Redirect("swagger");
                });
            });

        }
    }
}
