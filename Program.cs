using Microsoft.EntityFrameworkCore;
using Task.DAL;

namespace Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.MapControllerRoute(
                name: "Default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.UseStaticFiles();

            app.Run();
        }
    }
}