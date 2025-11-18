namespace DoorsWebProject.Web.Infrastructure.Extensions
{
	using Microsoft.AspNetCore.Builder;
	using Microsoft.Extensions.DependencyInjection;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
    using DoorsWebProject.Data.Seeding.Interfaces;

	public static class WebApplicationExtensions
	{
		public static IApplicationBuilder SeedDefaultIdentity(this IApplicationBuilder app)
		{
			using IServiceScope scope = app.ApplicationServices.CreateScope();
			IServiceProvider serviceProvider = scope.ServiceProvider;

			IIdentitySeeder identitySeeder = serviceProvider
				.GetRequiredService<IIdentitySeeder>();
			identitySeeder
				.SeedIdentityAsync()
				.GetAwaiter()
				.GetResult();

			return app;
		}
	}
}
