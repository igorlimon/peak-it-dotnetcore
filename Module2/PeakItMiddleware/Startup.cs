using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Http;

namespace PeakItMiddleware
{
    public class Startup
    {
        private readonly Exampels _exampels = new Exampels();

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices()
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            //_exampels.UseOrder(app);
            //_exampels.Map(app);
            //_exampels.MapWhen(app);
            _exampels.MapWhenOptions(app, new MapWhenOptions
            {
                Branch =
                    context =>
                        context.Response.WriteAsync($"olleh"),
                Predicate = context => context.Request.Path.Value.Contains("hello")
            });
        }
    }
}
