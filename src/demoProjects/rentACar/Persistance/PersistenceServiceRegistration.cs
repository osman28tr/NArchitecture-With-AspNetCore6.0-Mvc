using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("RentACarCampConnectionString")));
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IModelRepository, ModelRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
			services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
			services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
			return services;
        }
    }
}
