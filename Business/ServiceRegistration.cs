using Business.Abstract;
using Business.Concrete;
using Business.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ICurrentService, CurrentManager>();
            services.AddScoped<ICurrentLogService, CurrentLogManager>();
            services.AddScoped<IStockPriceService, StockPriceManager>();
            services.AddScoped<IStockService, StockManager>();
            services.AddAutoMapper(typeof(MappingProfiles));

            return services;
        }
    }
}
