namespace DoorsWebProject.Web.Infrastructure.Extensions
{
	using Microsoft.Extensions.DependencyInjection;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;
	using static GCommon.ExceptionMessages;

	public static class ServiceCollectionExtensions
	{
		public const string SuffixService = "Service";
		public const string PrefixInterface = "I";

		public const string SuffixRepository = "Repository";
		public static IServiceCollection AddUserDefinedServices(this IServiceCollection serviceCollection , Assembly serviceAssembly)
		{
			Type[] serviceClasses = serviceAssembly
				.GetTypes()
				.Where(t => !t.IsInterface &&
							t.Name.EndsWith(SuffixService))
				.ToArray();

			foreach(Type serviceClass in serviceClasses)
			{
				Type? serviceInterface = serviceClass
					.GetInterfaces()
					.FirstOrDefault(i => i.Name == $"{PrefixInterface}{serviceClass.Name}");

				if(serviceInterface == null)
				{
					throw new ArgumentException(InterfaceNotFoundMessage , serviceClass.Name);
				}

				serviceCollection.AddScoped(serviceInterface , serviceClass);
			}

			return serviceCollection;
		}

		public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection, Assembly repositoryAssembly)
		{
			Type[] repositoryClasses = repositoryAssembly
				.GetTypes()
				.Where(r =>  !r.IsInterface && 
				 !r.IsAbstract && r.Name.EndsWith(SuffixRepository))
				.ToArray();

			foreach (Type repositoryClass in repositoryClasses)
			{
				Type? repositoryInterface = repositoryClass
					.GetInterfaces()
					.FirstOrDefault(i => i.Name == $"{PrefixInterface}{repositoryClass.Name}");

				if(repositoryInterface == null)
				{
					throw new ArgumentException(InterfaceNotFoundMessage, repositoryClass.Name);
				}
				serviceCollection.AddScoped(repositoryInterface , repositoryClass);
			}

			return serviceCollection;
		}
	}
}
