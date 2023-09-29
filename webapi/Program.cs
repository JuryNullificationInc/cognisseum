using cognisseum.Entities;
using System.Diagnostics.Contracts;
using webapi;
using webapi.Entities.DataSeeding;

public class Program
{
    public static void Main(string[] args)
        => CreateHostBuilder(args).Build().Run();

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(host =>
        {
            host.UseStartup<Startup>();
        });

        return host;
    }
}
