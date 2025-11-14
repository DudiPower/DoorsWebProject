namespace DoorsWebProject.Data
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;
	using Microsoft.Extensions.Configuration;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorsDbContextFactory : IDesignTimeDbContextFactory<DoorsDbContext>
	{
		public DoorsDbContext CreateDbContext(string[] args)
		{
			var directory = Directory.GetCurrentDirectory();
			IConfigurationRoot configuration = null;

			// 🔍 Търсим DoorsWebProject.Web, а не DoorsWebProject
			while (directory != null)
			{
				var potentialPath = Path.Combine(directory, "DoorsWebProject.Web", "appsettings.json");
				if (File.Exists(potentialPath))
				{
					configuration = new ConfigurationBuilder()
						.AddJsonFile(potentialPath)
						.Build();
					break;
				}

				directory = Directory.GetParent(directory)?.FullName;
			}

			if (configuration == null)
			{
				throw new FileNotFoundException("Не е намерен appsettings.json в структурата на проекта.");
			}

			var connectionString = configuration.GetConnectionString("DefaultConnection");
			var optionsBuilder = new DbContextOptionsBuilder<DoorsDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new DoorsDbContext(optionsBuilder.Options);
		}
	}
}
