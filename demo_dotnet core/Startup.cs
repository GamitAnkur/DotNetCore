using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo_dotnet_core
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<CustomMiddleware>(); // Di for customMW

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // It is use to show error details in browser

            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            /*-- Example of  Middleware --*/

            /* app.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("1st Middleware start \n");
                    await next();
                    await context.Response.WriteAsync("1st Middleware end \n");

                });

            app.UseMiddleware<CustomMiddleware>(); // Calling Custome Middleware from other .cs class
                                                   // 
            app.Map("/customMiddleware", Customcode); // calling custome Middleware from same class

             app.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("2nd Middleware start \n");
                    await context.Response.WriteAsync("2nd  Middleware end \n");

                });*/
        }

        /*-- custome Middleware --*/
        /* private void Customcode(IApplicationBuilder app)
         {
             app.Use(async (context, next) =>
             {
                 await context.Response.WriteAsync("This is Custom middleware in program file");
             });
         }*/
    }
}
