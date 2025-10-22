namespace DoorsWebProject.Data.Repository
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using static DoorsWebProject.Data.Common.EntityConstants;

	public class WishlistRepository : BaseRepository<ApplicationUserDoor, object>, IWishlistRepository
	{
		public WishlistRepository(DoorsDbContext dbContext)
			: base(dbContext) 
		{
			
		}

		public ApplicationUserDoor? GetByCompositeKey(string userId, string doorId)
		{
			return this
				.GetAllAttached()
				.SingleOrDefault(aud => aud.DoorId.ToString().ToLower() == doorId.ToLower() &&
								 aud.ApplicationUserId.ToLower() == userId.ToLower());
		}

		public Task<ApplicationUserDoor?> GetByCompositeKeyAsync(string userId, string doorId)
		{
			return this
				.GetAllAttached()
				.SingleOrDefaultAsync(aud => aud.DoorId.ToString().ToLower() == doorId.ToLower() &&
								 aud.ApplicationUserId.ToLower() == userId.ToLower());
		}
		public bool Exists(string userId, string doorId)
		{
			return this
				.GetAllAttached()
				.Any(aud => aud.DoorId.ToString().ToLower() == doorId.ToLower() &&
								 aud.ApplicationUserId.ToLower() == userId.ToLower());
		}

		public Task<bool> ExistsAsync(string userId, string doorId)
		{
			return this
				.GetAllAttached()
				.AnyAsync(aud => aud.DoorId.ToString().ToLower() == doorId.ToLower() &&
								 aud.ApplicationUserId.ToLower() == userId.ToLower());
		}
	}
}
