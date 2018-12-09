using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PeakItDi
{
    public class Startup
    {
         public void Configure(IApplicationBuilder app)
        {            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPeakItService>(s => new PeakItService("MyConnectionString"));
        }
    }
}