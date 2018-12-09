using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;

namespace PeakItDi
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .Build()
                .Run();
        }

        private static void CustomImplementationOfDi()
        {
            var customDi = new CustomDi();
            customDi.PopulateService();

            var peakItService = customDi.GetPeakItService();
            System.Console.WriteLine(peakItService.GetConstructorParameter());
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                //.UseStartup<Startup>()
                .UseStartup<LifetimeDiStartup>()
                .UseEnvironment("Development");
    }
}
