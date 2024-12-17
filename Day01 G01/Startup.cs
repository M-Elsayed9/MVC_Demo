using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MVC_Demo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // Add MVC services to the container
            // services.AddRazorPages(); // Add Razor Pages services to the container
            // services.AddControllers(); // Add API controllers services to the container
            // services.AddMvc(); // Add MVC services to the container which includes Razor Pages and API controllers also
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); // middleware that enables routing

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/index", async context =>
                {
                    await context.Response.WriteAsync("Hello World From Index!");
                });

                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{Controller=Movies}/{action=Index}/{id:int?}" // id is optional and must be int
                    //default values for controller and action

                    //defaults: new {action = "Index"}, //old way
                    //constraints: new {id = new IntRouteConstraint()} // old way
                    );
            });
        }
    }
}
