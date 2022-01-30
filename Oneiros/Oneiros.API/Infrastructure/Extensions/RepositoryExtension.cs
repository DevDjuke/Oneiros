using Microsoft.Extensions.DependencyInjection;
using Oneiros.API.Repositories;
using Oneiros.Infrastructure.Repositories;
using Oneiros.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.API.Infrastructure.Extensions
{
    public static class RepositoryExtension
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IPlayerCampaignRepository, PlayerCampaignRepository>();
            services.AddScoped<ICampaignRepository, CampaignRepository>();
        }
    }
}
