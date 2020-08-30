using Application3;
using Business3;
using Data3;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApi3
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
            services.AddControllers();

            services.Scan(selector => selector.FromAssemblyOf<IBookUseCases>()
                .AddClasses(false).AsMatchingInterface().WithScopedLifetime());

            // Since the BookRepository is the only class in the repository and it is internal, the Data3 component is
            // made visible to main program with InternalsVisibleTo attribute.
            services.Scan(selector => selector.FromAssembliesOf(typeof(IBookService), typeof(BookRepository))
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