using Books2.Application;
using Books2.Business;
using Books2.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApi2.Controllers;

namespace WebApi2
{
    internal class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddApplicationPart(typeof(BooksController).Assembly);

            services.Scan(selector => selector.FromAssemblyOf<IBookUseCases>()
                .AddClasses(false).AsMatchingInterface().WithScopedLifetime());
            services.Scan(selector => selector.FromAssemblyOf<IBookService>()
                .AddClasses(false).AsMatchingInterface().WithScopedLifetime());
            services.Scan(selector => selector.FromAssemblyOf<IBookRepository>()
                .AddClasses(false).AsMatchingInterface().WithScopedLifetime());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}