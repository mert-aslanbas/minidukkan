using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniDukkan.Models;

namespace MiniDukkan
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<MiniDukkanContext>(opts => opts.UseSqlServer(Configuration
           ["ConnectionStrings:MiniDukkanConnection"]));
            services.AddScoped<IDukkanRepository, EFIDukkanRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseStatusCodePages(); 

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("katsayfa", "{kategori}/Sayfa{urunSayfa:int}", new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("sayfa", "Sayfa{urunSayfa:int}",
                    new { Controller = "Home", action = "Index", urunSayfa = 1 });


                endpoints.MapControllerRoute("kategori", "{kategori}",
                    new { Controller = "Home", action = "Index", urunSayfa = 1 });



                endpoints.MapControllerRoute("sayfalama", "Urunler/Sayfa{urunSayfa}",
                new { Controller = "Home", action = "Index", urunSayfa = 1 });
                endpoints.MapDefaultControllerRoute();
            });

            HamVeri.VeriDoldur(app);

        }
    }
}
