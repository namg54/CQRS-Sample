using Infrastucture.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Test_Web
{
    public static class ConfigurService
    {
        public static IServiceCollection AddWebServiceCollection(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            return builder.Services;
        }
    }
}
