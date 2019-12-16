using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TheShopCore.Domain.Models;
using TheShopCore.Domain.Repositories;
using TheShopCore.Domain.Interfaces;

namespace TheShopCore.Domain.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddTheShopCoreDomain(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTransient<IUnitOfWork, UnitOfWork>();            
            services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericRepository<>));
           
            // Change in accordance to your db
            var connection = @"";
            services.AddDbContext<TheShopCoreContext>
                (options => options.UseSqlServer(connection));
            return services;
        }
    }
}
