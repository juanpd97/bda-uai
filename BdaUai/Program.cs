using BdaUai.Models;
using Microsoft.EntityFrameworkCore;

namespace BdaUai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //inyeccion de dependecia
            builder.Services.AddDbContext<BibliotecaContext>(o =>
            {
                o.UseSqlServer(builder.Configuration.GetConnectionString("bda-uai"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

            //xd
        }
    }
}