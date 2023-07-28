using RoleplaySanctuary.DAL;
using RoleplaySanctuary.DAL.Options;

namespace RoleplaySanctuary
{
    public static class ServicesConfiguration
    {
        public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.Configure<PostgresOptions>(builder.Configuration.GetRequiredSection("PostgresOptions"));
            builder.Services.AddDataAccess();

            return builder;
        }
    }
}
