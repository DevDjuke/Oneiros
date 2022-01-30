namespace Oneiros.Web.Extensions
{
    public static class HttpExtensions
    {
        public static void ConfigureHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient("API", httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://localhost:7179/");
            });
        }
    }
}
