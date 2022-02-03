using adduo.elephant.repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Linq;

namespace adduo.elephant.console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            //    .AddJsonFile("appsettings.json", false)
            //    .Build();

            //var collection = new ServiceCollection();

            ////collection.AddDatabaseContext(configuration);

            //var serviceProvider = collection.BuildServiceProvider();
            //var dbContext = serviceProvider.GetService<ElephantContext>();

            //var x = dbContext.Categories.Count();
            //Console.WriteLine(">>> {0}", x);

            //var xx = dbContext.InComes.Count();
            //Console.WriteLine(">>> {0}", xx);
        }

    }


}
