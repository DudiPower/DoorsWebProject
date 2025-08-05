namespace DoorsWebProject.Services.Core
{
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Wishlist;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using static DoorsWebProject.Data.Common.EntityConstants;

	public class WishlistService : IWishlistService
	{
		private readonly DoorsDbContext dbContext;

		public WishlistService(DoorsDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<IEnumerable<WishlistViewModel>> GetWishlistDoorsAsync(string userId)
		{
			IEnumerable<WishlistViewModel> userWishlist = await this.dbContext
				.ApplicationUserDoors
				.AsNoTracking()
				.Where(aud => aud.ApplicationUserId.ToLower() == userId.ToLower())
				.Select(aud => new WishlistViewModel
				{
					Id = aud.DoorId.ToString(),
					Model = aud.Door.Model,
					ImageUrl = aud.Door.ImageUrl,
					Price = aud.Door.Price.ToString(),
				})
				.ToArrayAsync();

			return userWishlist;
		}

		public async Task<bool> AddDoorToWishlistAsync(string? doorId, string? userId)
		{
			bool result = false;

			if (userId != null && doorId != null)
			{
				bool isValidDoorId = Guid.TryParse(doorId, out Guid doorGuid);

				if (isValidDoorId)
				{
					ApplicationUserDoor? userDoorEntity = await this.dbContext
						.ApplicationUserDoors
						.IgnoreQueryFilters()
						.SingleOrDefaultAsync(aud => aud.ApplicationUserId.ToLower() == userId
						&& aud.DoorId.ToString() == doorGuid.ToString());

					if (userDoorEntity != null)
					{
						userDoorEntity.IsDeleted = false;
					}
					else
					{
						userDoorEntity = new ApplicationUserDoor()
						{
							ApplicationUserId = userId,
							DoorId = doorGuid
						};

						await this.dbContext.ApplicationUserDoors.AddAsync(userDoorEntity);


					}

					await this.dbContext.SaveChangesAsync();

					result = true;
				}
			}

			return result;
		}

		public async Task<bool> RemoveDoorFromWishlistAsync(string? doorId, string? userId)
		{
			bool result = false;

			if (userId != null && doorId != null)
			{
				bool isValidDoorId = Guid.TryParse(doorId, out Guid doorGuid);

				if (isValidDoorId)
				{
					ApplicationUserDoor? userDoorEntity = await this.dbContext
						.ApplicationUserDoors
						.SingleOrDefaultAsync(aud => aud.ApplicationUserId == userId
						&& aud.DoorId == doorGuid);

					if (userDoorEntity != null)
					{
						userDoorEntity.IsDeleted = true;

						await this.dbContext.SaveChangesAsync();

						result = true;
					}
				}
			}

			return result;
		}

		
	}
}
