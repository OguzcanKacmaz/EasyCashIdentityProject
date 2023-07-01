using EasyCash.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EasyCash.DataAccessLayer.Extensions;

public static class DataAccessDI
{
    public static IServiceCollection AddDbContextConnection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString(ApplicationDbContext.ConnectionName));
        });
        return services;
    }
}
