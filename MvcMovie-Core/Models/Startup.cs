using Microsoft.EntityFrameworkCore;
using MvcMovie_Core.Data;

namespace MvcMovie_Core.Models
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            /*services.AddControllersWithViews();

            services.AddDbContext<MvcMovie_CoreContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));*/
        }
    }
}
