namespace DoorsWebProject.WebApi
{
	using DoorsWebProject.Data;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;

	public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
				?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

			builder.Services
				.AddDbContext<DoorsDbContext>(options =>
				{
					options.UseSqlServer(connectionString);
				});

			builder.Services.AddControllers();

			builder.Services.AddAuthorization();

			builder.Services.AddIdentityApiEndpoints<IdentityUser>()
				            .AddEntityFrameworkStores<DoorsDbContext>();
		
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapIdentityApi<IdentityUser>();
			app.MapControllers();

			app.Run();
		}
	}
}
