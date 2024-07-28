using EmrysSerenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmrysSeren2.0
{
    public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        //services.AddDbContext<ESDbContext>(options => options.UseSqlite(database);


    }
}
}
