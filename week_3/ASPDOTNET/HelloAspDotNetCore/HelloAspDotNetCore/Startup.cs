using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAspDotNetCore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                // request processing logic before the next middleware runs
                if (context.Request.Path == "/htmlpage.html")
                {
                    string path = "./htmlpage.html";

                    string htmlText = File.ReadAllText(path);

                    await context.Response.WriteAsync(htmlText);
                }
                else
                {
                    // later middlewares run
                    await next();
                }
            });

            app.Run(async context =>
            {
                // this object has all the details of the request
                HttpRequest request = context.Request;

                // we can modify this object to set up the response.
                HttpResponse response = context.Response;

                response.ContentType = "text/html";
                await response.WriteAsync("Default");
            });

        }
    }
}
