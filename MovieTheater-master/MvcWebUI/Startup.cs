using Business.Services.Abstract;
using Business.Services.Concrete;
using DataAccess.Context;
using DataAccess.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            //services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer("server=.;database=MovieTheaterDB;uid=sa;pwd=123;"));

            services.AddDbContext<ApplicationDbContext>();

            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddSingleton<IGenreService, GenreService>();
            services.AddSingleton<IMovieService, MovieService>();
            services.AddSingleton<IReservationService, ReservationService>();
            services.AddSingleton<IMovieGenreService, MovieGenreService>();
            services.AddSingleton<ISalloonService, SalloonService>();
            services.AddSingleton<IWeekService, WeekService>();
            services.AddSingleton<ISessionService, SessionService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");             
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(x =>
            {
                x.MapControllerRoute(
                    name:"AdminArea",
                    pattern: "{Area:Exists}/{Controller=Home}/{Action=Index}/{id?}"
                    );

                x.MapControllerRoute(
                    name:"default",
                    pattern: "{Controller=Home}/{Action=Index}/{id?}"
                    );
            });
        }
    }
}
