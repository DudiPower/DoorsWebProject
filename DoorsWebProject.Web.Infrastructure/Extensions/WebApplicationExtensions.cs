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
	using DoorsWebProject.Web.Infrastructure.Middlewares;

	public static class WebApplicationExtensions
	{
		public static IApplicationBuilder UserAdminRedirection(this IApplicationBuilder builder)
		{
			builder.UseMiddleware<AdminRedirectionMiddleware>();

			return builder;
		}


		public static IApplicationBuilder SeedDefaultIdentity(this IApplicationBuilder builder)
		{
			using IServiceScope scope = builder.ApplicationServices.CreateScope();
			IServiceProvider serviceProvider = scope.ServiceProvider;

			IIdentitySeeder identitySeeder = serviceProvider
				.GetRequiredService<IIdentitySeeder>();
			identitySeeder
				.SeedIdentityAsync()
				.GetAwaiter()
				.GetResult();

			return builder;
		}
	}
}
