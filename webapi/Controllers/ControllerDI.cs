using cognisseum.Entities;
using cognisseum.Services;
using webapi.Services;

namespace webapi.Controllers
{
    public class ControllerDI
    {
        public ControllerDI(IServiceCollection svcs) => services = svcs;

        public IServiceCollection InjectDependencies()
        {
            services.AddScoped<CgnContext>();
            services.AddScoped<StoichiometryService>();
            services.AddScoped<ElementService>();
            return services;
        }

        public IServiceCollection services { get; set; }
    }
}
