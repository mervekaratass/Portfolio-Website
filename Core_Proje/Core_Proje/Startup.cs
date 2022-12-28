using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //identityde eklemesi için startup da bu iki satrýý eklemem lazým 
           
            services.AddDbContext<Context>();
            services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();

            //bunuda proje bazýnda otantike olma iþlemi için yaptým bunnu yazmasam tek tek diðer tek satýrlýk eklemiþ olduðum
            //configurasyon eklentilerini ekleyip controllerýlarýmýn baþlarýna[Authorize] yazmam gerekiyordu ama bunu yapýnca gerek kalmýyor 
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                   .RequireAuthenticatedUser()
                                   .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
                

            });

            //BUNU YAPMIYORUM BU ÇALIÞMIYOR
            //services.AddAuthentication(
            //    CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(x =>
            //    {
            //        x.LoginPath = "/AdminLogin/Index";
            //    });
            
            //alttaki service ekliyotum bu otantike deðise ve girmeye çalýþtýysa beni writer içindeki login in index sayfasýna yönlendiricek
            //burdan sisteme otantike olabilirim

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
                options.AccessDeniedPath = "/ErrorPage/Index/";
                options.LoginPath = "/Writer/Login/Index/";


            }) ; 
            
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");
            app.UseHttpsRedirection();
            app.UseStaticFiles(); 
         
            //bu otantike iþlemleri için eklediðim satýr
            app.UseAuthentication();
          

            app.UseRouting();

            //bu da yine otantike iþlem yapýlmasý için eklediim bir satýr
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
                );
            });
        }
    }
}
