using Bme.Swlab1.Rest.Dal.Entities;

using Microsoft.AspNetCore;

namespace Bme.Swlab1.Rest;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateWebHostBuilder(args).Build();

        // initialize database, as recommended at https://docs.microsoft.com/en-us/aspnet/core/migration/1x-to-2x/?view=aspnetcore-2.1#move-database-initialization-code
        using (var serviceScope = host.Services.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetRequiredService<TasksDbContext>();
            context.Database.EnsureCreated();
        }

        host.Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseUrls("http://localhost:5000");
}
