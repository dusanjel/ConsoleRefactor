using Microsoft.Extensions.DependencyInjection;
using System;
using TheShopCore.IoC;

namespace TheShopCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = InversionOfControl.GetServiceProvider();

            // Get Service and call method
            //var service = serviceProvider.GetService<TheShopCoreService>();
            //service.MyServiceMethod();
        }
    }
}
