using cognisseum.Entities;
using Microsoft.EntityFrameworkCore;
using webapi.Controllers;
using webapi.Services;

namespace webapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    // force to add another /swagger to fix issue
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cognisseum 1.0");
                });

                app.UseHttpsRedirection();
                app.UseRouting();
                app.UseAuthorization();
                app.UseEndpoints(e =>
                {
                    e.MapControllers();
                });
            }
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CgnContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddRouting();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            var di = new ControllerDI(services);
            services = di.InjectDependencies();
        }
    }
}
