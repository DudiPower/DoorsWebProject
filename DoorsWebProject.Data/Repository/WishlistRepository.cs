namespace DoorsWebProject.Data.Repository
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class WishlistRepository : BaseRepository<ApplicationUserDoor, object>, IWishlistRepository
	{
		public WishlistRepository(DoorsDbContext dbContext)
			: base(dbContext) 
		{
			
		}

		public ApplicationUserDoor? GetByCompositeKey(string userId, string movieId)
		{
			throw new NotImplementedException();
		}

		public Task<ApplicationUserDoor?> GetByCompositeKeyAsync(string userId, string movieId)
		{
			throw new NotImplementedException();
		}
		public bool Exists(string userId, string movieId)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistsAsync(string userId, string movieId)
		{
			throw new NotImplementedException();
		}
	}
}
