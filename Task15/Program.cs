using Microsoft.EntityFrameworkCore;
using Task15.Models.DbContexts;

namespace Task15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseInMemoryDatabase("CountriesDb");
            });

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Countries}/{action=Index}/{id?}");

            app.Seed();

            app.Run();
        }
    }
}
