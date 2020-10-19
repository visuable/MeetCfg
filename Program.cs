using Microsoft.Extensions.DependencyInjection;
using System;

namespace MeetCfg
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            
            services.AddSingleton<IDataCollector, ConsoleDataCollector>();
            services.AddDbContext<ApplicationContext>();

            services.AddSingleton<Configurator>();
            services.BuildServiceProvider();

            var provider = services.BuildServiceProvider();
            var configurator = provider.GetRequiredService<Configurator>();
            configurator.Configure();
        }
    }
}
