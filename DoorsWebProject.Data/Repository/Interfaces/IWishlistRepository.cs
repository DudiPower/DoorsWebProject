namespace DoorsWebProject.Data.Repository.Interfaces
{
	using DoorsWebProject.Data.Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IWishlistRepository : 
		IRepository<ApplicationUserDoor , object> , IAsyncRepository<ApplicationUserDoor , object>
	{
		ApplicationUserDoor? GetByCompositeKey(string userId, string movieId);

		Task<ApplicationUserDoor?> GetByCompositeKeyAsync(string userId, string movieId);

		bool Exists(string userId, string movieId);

		Task<bool> ExistsAsync(string userId, string movieId);
	}
}
