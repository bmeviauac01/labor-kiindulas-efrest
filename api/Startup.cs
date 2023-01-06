using Bme.Swlab1.Rest.Dal.Entities;
using Bme.Swlab1.Rest.Services;

using Microsoft.EntityFrameworkCore;

namespace Bme.Swlab1.Rest;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddDbContext<TasksDbContext>(options => options.UseSqlite("Data Source=tasks.db"));
        services.AddScoped<IStatusService, StatusService>();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
