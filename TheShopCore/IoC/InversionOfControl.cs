using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace TheShopCore.IoC
{
    public static class InversionOfControl
    {
        public static IServiceProvider GetServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            return services.BuildServiceProvider();
        }
    }
}
