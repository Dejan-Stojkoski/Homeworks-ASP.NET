using EStoreApp.DataAccess;
using EStoreApp.DataAccess.Repositories;
using EStoreApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EStoreApp.Services.Helpers
{
    public static class DIModule
    {
        public static IServiceCollection RegisterDatabase(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EStoreDbContext>(x => x.UseSqlServer(connectionString));

            return services;
        }

        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Product>, ProductRepository>();
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Review>, ReviewRepository>();

            return services;
        }
    }
}
