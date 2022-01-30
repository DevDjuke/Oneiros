using Oneiros.Infrastructure.Web;
using Oneiros.Web.Services;

namespace Oneiros.Web.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICampaignWebService, CampaignWebService>();
        }
    }
}
