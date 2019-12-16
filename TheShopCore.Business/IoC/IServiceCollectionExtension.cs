using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Domain.IoC;
using TheShopCore.Domain.Interfaces;
using TheShopCore.Domain.Repositories;
using TheShopCore.Domain.Models;
using TheShopCore.Business.Interfaces;
using TheShopCore.Business.Services;

namespace TheShopCore.Business.IoC
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddTheShopCoreBusiness(this IServiceCollection services)
        {
            //Register dependencies here
            //services.AddTransient<IGetMeRepo, GetMe>();   
            services.AddTheShopCoreDomain();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<TheShopCoreContext, TheShopCoreContext>();
            return services;
        }
    }
}
