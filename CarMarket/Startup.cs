using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using CarMarket.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CarMarket.Data.Interfaces;
using CarMarket.Data.Repository;
using Microsoft.AspNetCore.Http;
using CarMarket.Data.Models;

namespace CarMarket
{
    public class Startup
    {
        private IConfigurationRoot Configuration;

        public Startup(IHostEnvironment configuration)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(configuration.ContentRootPath).AddJsonFile("appsettings.json").Build();
            
        }

     
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppDbContent>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppDbContent>();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddTransient<IAllCars,CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            
            //Добавляю карзину
            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();
            services.AddScoped(p => Cart.GetCart(p));

            services.AddMvc();
            //Память каризны
            services.AddMemoryCache();
            services.AddSession();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
               
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //Чтобы Session работал!
            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContent content = scope.ServiceProvider.GetRequiredService<AppDbContent>();
                DBobjects.Initial(content);
            }



        }
    }
}
