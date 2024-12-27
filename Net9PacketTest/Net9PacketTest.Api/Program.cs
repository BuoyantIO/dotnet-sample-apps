using Microsoft.AspNetCore;

namespace Net9PacketTest.Api;

public class Program
{
    public static void Main(string[] args)
    {
        BuildWebHost(args).Run();
    }

    private static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((_, config) =>
            {
                // clearing sources below so we start with clean slate
                config.Sources.Clear();
                config.AddJsonFile("Conf/appsettings.json", optional: true, reloadOnChange: true);
                config.AddEnvironmentVariables();
            })
            .ConfigureLogging(config => config.ClearProviders())
            .UseStartup<Startup>()
            .Build();
}
