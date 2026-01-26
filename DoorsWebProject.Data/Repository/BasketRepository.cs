namespace DoorsWebProject.Data.Repository
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using Microsoft.AspNetCore.Hosting.Server;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketRepository
		: BaseRepository<Basket, Guid> , IBasketRepository
	{


		private readonly UserManager<ApplicationUser> applicationUser;
		private readonly IHttpContextAccessor httpContextAccessor;
		
		public BasketRepository(DoorsDbContext dbContext , IHttpContextAccessor httpContextAccessor , 
			UserManager<ApplicationUser> applicationUser)
			: base(dbContext) 
		{
			this.applicationUser = applicationUser;
			this.httpContextAccessor = httpContextAccessor;
		}

		public async Task<int> AddItem(int doorId , int quantity)
		{
			string userId = GetUserId();
			using var transaction = dbContext.Database.BeginTransaction();
			try
			{
				if (string.IsNullOrEmpty(userId))
					throw new UnauthorizedAccessException("user is not logged-in");
				var basket = await GetBasket(userId);
				if (basket is null)
				{
					basket = new Basket
					{
						ApplicationUserId = userId
					};
					dbContext.Baskets.Add(basket);
				}
				dbContext.SaveChanges();
				// cart detail section
				var basketItem = dbContext.BasketDetails
								  .FirstOrDefault(a => a.BasketId.ToString() == basket.ApplicationUserId && a.DoorId.ToString() == doorId.ToString());
				if (basketItem is not null)
				{
					basketItem.Quantity += quantity;
				}
				else
				{
					var door = dbContext.Doors.Find(doorId);

					bool isDoorIdCanParse = Guid.TryParse(doorId.ToString(), out Guid parsedDoorId);

					basketItem = new BasketDetail
					{
						DoorId = parsedDoorId,
						BasketId = basket.BasketId,
						Quantity = quantity,
						UnitPrice = door!.Price  // it is a new line after update
					};
					dbContext.BasketDetails.Add(basketItem);
				}
				dbContext.SaveChanges();
				transaction.Commit();
			}
			catch (Exception ex)
			{
			}
			var basketItemCount = await GetBasketItemCount(userId);
			return basketItemCount;
		}

		public async Task<int> RemoveItem(int doorId)
		{
			//using var transaction = _db.Database.BeginTransaction();
			string userId = GetUserId();
			try
			{
				if (string.IsNullOrEmpty(userId))
					throw new UnauthorizedAccessException("user is not logged-in");
				var basket = await GetBasket(userId);
				if (basket is null)
					throw new InvalidOperationException("Invalid basket");
				// cart detail section
				var basketItem = dbContext.BasketDetails
								  .FirstOrDefault(a => a.BasketId == basket.BasketId && a.DoorId.ToString() == doorId.ToString());
				if (basketItem is null)
					throw new InvalidOperationException("Not items in basket");
				else if (basketItem.Quantity == 1)
					dbContext.BasketDetails.Remove(basketItem);
				else
					basketItem.Quantity = basketItem.Quantity - 1;
				dbContext.SaveChanges();
			}
			catch (Exception ex)
			{

			}
			var cartItemCount = await GetBasketItemCount(userId);
			return cartItemCount;
		}

		public async Task<Basket> GetBasket(string userId)
		{
			var basket = await dbContext.Baskets.FirstOrDefaultAsync(b => b.ApplicationUserId == userId);

			return basket;
		}

		public async Task<int> GetBasketItemCount(string userId = "")
		{
			if (string.IsNullOrEmpty(userId)) // updated line
			{
				userId = GetUserId();
			}
			var data = await (from basket in dbContext.Baskets
							  join basketDetail in dbContext.BasketDetails
							  on basket.BasketId equals basketDetail.BasketId
							  where basket.ApplicationUserId == userId // updated line
							  select new { basketDetail.BasketDetailId }
						).ToListAsync();
			return data.Count;
		}

		private string GetUserId()
		{
			var principal = httpContextAccessor.HttpContext.User;
			string userId = applicationUser.GetUserId(principal);
			return userId;
		}

	}
}
