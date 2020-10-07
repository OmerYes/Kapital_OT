using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OT.DAL.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.CodeAnalysis.Options;

namespace OT.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
         .AddCookie(options =>
         {
             options.LoginPath = new PathString("/login");
         });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id=id}");
                endpoints.MapControllerRoute("exist", "{area=Admin}/{controller=Home}/{action=Index}");
            });
        }
    }
}
