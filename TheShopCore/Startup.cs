using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TheShopCore.Business.IoC;

namespace TheShopCore
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add business layer IoC
            services.AddTheShopCoreBusiness();
            services.AddSingleton<IConfigurationRoot>(Configuration);
        }
    }
}
