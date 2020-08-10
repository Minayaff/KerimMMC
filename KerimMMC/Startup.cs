using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using KerimMMC.DAL;
using KerimMMC.Route;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace KerimMMC
{
    public class Startup
    {
        //public Startup(IHostingEnvironment env)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(env.ContentRootPath)
        //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        //        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

        //    if (env.IsDevelopment())
        //    {
        //        // For more details on using the user secret store see https://go.microsoft.com/fwlink/?LinkID=532709
        //        builder.AddUserSecrets<Startup>();
        //    }

        //    builder.AddEnvironmentVariables();
        //    _configuration = builder.Build();
        //}

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
            });

            services.AddIdentity<IdentityUser, IdentityRole>(options => options.Stores.MaxLengthForKeys = 128)
             .AddEntityFrameworkStores<AppDbContext>()
            // .AddDefaultUI()
             .AddDefaultTokenProviders();


            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.Configure<RouteOptions>(options =>
            {
                options.ConstraintMap.Add("lang", typeof(RouteConstraint));
                options.ConstraintMap.Add("account", typeof(AccountRouteConstraint));
            });


            services
                .AddMvc()
                .AddViewLocalization(o => o.ResourcesPath = "Resources");

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("az-Latn-AZ"),
                    new CultureInfo("ru-RU"),
                    new CultureInfo("en-US")

                };

                options.DefaultRequestCulture = new RequestCulture(culture: "az-Latn-AZ", uiCulture: "az-Latn-AZ");

                options.SupportedCultures = supportedCultures;

                options.SupportedUICultures = supportedCultures;

                options.RequestCultureProviders.Insert(0, new RouteCultureProvider(options.DefaultRequestCulture));

            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            var localizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(localizationOptions.Value);

            app.UseMvc(routes =>
            {
                //route for admin
                routes.MapRoute(
                      name: "areas",
                      template: "{area:exists}/{controller=Blog}/{action=Index}/{id?}"
                    );

                //route for everything
                routes.MapRoute(
                      name: "default",
                      template: "{lang=az}/{controller=Language}/{action=Index}/{id?}");
            });
        }
    }
}
