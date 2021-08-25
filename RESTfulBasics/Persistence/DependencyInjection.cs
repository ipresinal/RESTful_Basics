using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Persistence.Contexts;
using Persistence.Repository;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                ));


            #region Repositories

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>));

            #endregion
        }
    }
}
