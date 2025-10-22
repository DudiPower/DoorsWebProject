namespace DoorsWebProject.Web
{
	using DoorsWebProject.Services.Core;
	using DoorsWebProject.Services.Core.Interfaces;
	using Data;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Data.Repository;

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
                .AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedEmail = false;
                    options.SignIn.RequireConfirmedPhoneNumber = false;

                    options.Password.RequiredLength= 3;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequiredUniqueChars = 0;
                })
                .AddEntityFrameworkStores<DoorsDbContext>();

            builder.Services.AddScoped<IDoorRepository, DoorRepository>();
			builder.Services.AddScoped<IBasketRepository, BasketRepository>();
			builder.Services.AddScoped<IWishlistRepository, WishlistRepository>();
			builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

			builder.Services.AddScoped<IDoorService, DoorService>();
			builder.Services.AddScoped<IWishlistService, WishlistService>();
            builder.Services.AddScoped<IBasketService, BasketService>();

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

            app.UseAuthentication();
            app.UseAuthorization();

			app.UseSession();

			app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
