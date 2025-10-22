namespace DoorsWebProject.Services.Core
{
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
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
		
		private readonly IWishlistRepository wishlistRepository;
		public WishlistService(IWishlistRepository wishlistRepository)
		{
			this.wishlistRepository = wishlistRepository;
		}

		public async Task<IEnumerable<WishlistViewModel>> GetWishlistDoorsAsync(string userId)
		{
			IEnumerable<WishlistViewModel> userWishlist = await this.wishlistRepository
				.GetAllAttached()
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
					ApplicationUserDoor? userDoorEntity = await this.wishlistRepository
						.GetAllAttached()
						.IgnoreQueryFilters()
						.SingleOrDefaultAsync(aud => aud.ApplicationUserId.ToLower() == userId
						&& aud.DoorId.ToString() == doorGuid.ToString());

					if (userDoorEntity != null)
					{
						userDoorEntity.IsDeleted = false;
						result = 
							await this.wishlistRepository.UpdateAsync(userDoorEntity);
					}
					else
					{
						userDoorEntity = new ApplicationUserDoor()
						{
							ApplicationUserId = userId,
							DoorId = doorGuid
						};

						await this.wishlistRepository.AddAsync(userDoorEntity);
						result = true;
					}
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
					ApplicationUserDoor? userDoorEntity = await this.wishlistRepository
						.SingleOrDefaultAsync(aud => aud.ApplicationUserId == userId
						&& aud.DoorId == doorGuid);

					if (userDoorEntity != null)
					{
						await this.wishlistRepository.SoftDeleteAsync(userDoorEntity);

						result = true;
					}
				}
			}

			return result;
		}
	}
}
