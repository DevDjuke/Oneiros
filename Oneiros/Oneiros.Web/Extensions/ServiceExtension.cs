using Oneiros.Web.Services;
using Oneiros.Web.Services.Base;

namespace Oneiros.Web.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ICampaignWebService, CampaignWebService>();
            services.AddScoped<INPCWebService, NPCWebService>();
            services.AddScoped<IAdminWebService, AdminWebService>();
            services.AddScoped<ILanguageWebService, LanguageWebService>();
            services.AddScoped<IRaceWebService, RaceWebService>();
            services.AddScoped<IPresetWebService, PresetWebService>();
        }
    }
}
