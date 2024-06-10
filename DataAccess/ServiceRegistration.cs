using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExampleDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BaseConnection")));
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ExampleDbContext>();
            services.AddScoped<IStockDal, EfStockDal>();
            services.AddScoped<IStockPriceDal, EfStockPriceDal>();
            services.AddScoped<ICurrentDal, EfCurrentDal>();
            services.AddScoped<IAddressDal, EfAddressDal>();
            services.AddScoped<ICurrentLogDal, EfCurrentLogDal>();
            return services;
        }

    }
}
