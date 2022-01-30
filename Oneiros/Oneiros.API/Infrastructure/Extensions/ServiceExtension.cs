using Oneiros.API.Infrastructure.Services;
using Oneiros.Infrastructure.Services;

namespace Oneiros.API.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<ICampaignService, CampaignService>();
        }
    }
}
