using DoorsWebProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace DoorsWebProject.Web
{
	using Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Data.Seeding;
	using DoorsWebProject.Data.Seeding.Interfaces;
	using DoorsWebProject.Services.Core;
	using DoorsWebProject.Services.Core.Interfaces;
    using DoorsWebProject.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

	public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
				options.IdleTimeout = TimeSpan.FromMinutes(30);
				options.Cookie.HttpOnly = true;
				options.Cookie.IsEssential = true;
			});
            
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            
            builder.Services
                .AddDbContext<DoorsDbContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                });
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services
                .AddDefaultIdentity<ApplicationUser>(options =>
                {
                    ConfigureIdentity(builder.Configuration, options);

				})
				.AddRoles<IdentityRole>()
				.AddEntityFrameworkStores<DoorsDbContext>();

            builder.Services.AddScoped<IDoorRepository, DoorRepository>();
			builder.Services.AddScoped<IBasketRepository, BasketRepository>();
			builder.Services.AddScoped<IWishlistRepository, WishlistRepository>();
			builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

			builder.Services.AddScoped<IDoorService, DoorService>();
			builder.Services.AddScoped<IWishlistService, WishlistService>();
            builder.Services.AddScoped<IBasketService, BasketService>();

			builder.Services.AddTransient<IIdentitySeeder, IdentitySeeder>();

			builder.Services.AddControllersWithViews();

            WebApplication? app = builder.Build();
            
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

			app.SeedDefaultIdentity();

			app.UseAuthentication();
            app.UseAuthorization();

			app.UseSession();

			app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }

        private static void ConfigureIdentity(IConfigurationManager configurationManager , IdentityOptions identityOptions)
        {

			identityOptions.SignIn.RequireConfirmedAccount = 
                configurationManager.GetValue<bool>($"IdentityConfig:SignIn:RequireConfirmedAccount");

			identityOptions.SignIn.RequireConfirmedEmail =
				configurationManager.GetValue<bool>($"IdentityConfig:SignIn:RequireConfirmedEmail"); 

			identityOptions.SignIn.RequireConfirmedPhoneNumber =
				configurationManager.GetValue<bool>($"IdentityConfig:SignIn:RequireConfirmedPhoneNumber");



			identityOptions.Password.RequiredLength =
				configurationManager.GetValue<int>($"IdentityConfig:Password:RequiredLength"); 
			identityOptions.Password.RequireNonAlphanumeric =
				configurationManager.GetValue<bool>($"IdentityConfig:Password:RequireNonAlphanumeric"); 
			identityOptions.Password.RequireDigit =
				configurationManager.GetValue<bool>($"IdentityConfig:Password:RequireDigit"); 
			identityOptions.Password.RequireLowercase =
				configurationManager.GetValue<bool>($"IdentityConfig:Password:RequireLowercase"); 
			identityOptions.Password.RequireUppercase =
				configurationManager.GetValue<bool>($"IdentityConfig:Password:RequireUppercase"); 
			identityOptions.Password.RequiredUniqueChars =
				configurationManager.GetValue<int>($"IdentityConfig:Password:RequiredUniqueChars"); 
		}
    }
}
