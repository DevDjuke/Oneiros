using System.Text.Json;

namespace Oneiros.API.Infrastructure.Extensions
{
    public static class JsonExtension
    {
        public static void ConfigureJsonServices(this IServiceCollection services)
        {
            services.AddMvc()
                        .AddJsonOptions(options =>
                        {
                            options.JsonSerializerOptions.PropertyNamingPolicy = null;
                        });
        }
    }
}
