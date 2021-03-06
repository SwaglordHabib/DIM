using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SH.DIM.Models;
using SH.DIM.Models.Contracts;
using SH.DIM.Services;

namespace SH.DIM.Utils
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration Configuration)
        {

            DatabaseSettings Databasesettings = new();
            Configuration.GetSection(nameof(DatabaseSettings)).Bind(Databasesettings);

             // Databasesettings
            services.AddSingleton<IDatabaseSettings>(sp => sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);

            // Services
            services.AddSingleton<ICommodityService, CommodityService>();


            return services;
        }
    }
}