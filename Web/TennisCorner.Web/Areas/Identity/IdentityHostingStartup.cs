using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(TennisCorner.Web.Areas.Identity.IdentityHostingStartup))]

namespace TennisCorner.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
