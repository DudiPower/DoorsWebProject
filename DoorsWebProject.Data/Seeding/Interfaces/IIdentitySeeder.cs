namespace DoorsWebProject.Data.Seeding.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IIdentitySeeder
	{
		Task SeedIdentityAsync();
	}
}
