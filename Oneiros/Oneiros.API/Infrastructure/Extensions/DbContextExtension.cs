using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.API.Infrastructure.Extensions
{
    public static class DbContextExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OneirosContext>(options =>
                options.UseSqlServer(connectionString));

        }
    }
}
