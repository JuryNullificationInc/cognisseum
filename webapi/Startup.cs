using cognisseum.Entities;
using Microsoft.EntityFrameworkCore;

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
                    c.RoutePrefix = "swgr";
                });
                app.UseHttpsRedirection();
                app.UseAuthorization();
                app.UseRouting();
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
        }
    }
}
