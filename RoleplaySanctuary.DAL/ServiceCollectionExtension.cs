using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RoleplaySanctuary.DAL.Options;
using RoleplaySanctuary.DAL.Repositories;
using RoleplaySanctuary.DAL.Repositories.Interfaces;

namespace RoleplaySanctuary.DAL
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            var assembly = typeof(ServiceCollectionExtension).Assembly;

            services.AddDbContext<RoleplaySanctuaryDbContext>((sp, builder) =>
            {
                var dbOptions = sp.GetRequiredService<IOptions<PostgresOptions>>().Value;
                var connectionString = dbOptions.ConnectionString;

                builder
                .EnableSensitiveDataLogging(true)
                .UseNpgsql(dbOptions.ConnectionString);
            });

            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
