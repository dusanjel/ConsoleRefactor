using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Domain.IoC;
using TheShopCore.Domain.Interfaces;
using TheShopCore.Domain.Repositories;
using TheShopCore.Domain.Models;

namespace TheShopCore.Business.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddTheShopCoreBusiness(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<TheShopCoreContext, TheShopCoreContext>();         

            services.AddTheShopCoreDomain();            
            return services;
        }
    }
}
