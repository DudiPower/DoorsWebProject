namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Wishlist;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	public class WishlistController : BaseController
	{
		private readonly IWishlistService wishlistService;

		public WishlistController(IWishlistService wishlistService)
		{
			this.wishlistService = wishlistService;
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{
			try
			{
				string? userId = this.GetUserId();

				if (userId == null)
				{
					return this.Forbid();
				}

				IEnumerable<WishlistViewModel> doorWishlist = await this.wishlistService
					.GetWishlistDoorsAsync(userId);

				return View(doorWishlist);

			}
			catch(Exception e) 
			{
				Console.WriteLine(e.Message);

				return this.RedirectToPage(nameof(Index), "Home");
			}
		}

		[HttpPost]
		public async Task<IActionResult> Add(string? id)
		{
			try
			{
				string? userId = this.GetUserId();

				if (userId == null)
				{
					return Forbid();
				}

				bool result = await this.wishlistService
					.AddDoorToWishlistAsync(id, userId);

				if (result == false)
				{
					return this.RedirectToAction(nameof(Index), "Door");
				}

				return this.RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index), "Home");
			}
		
		}

		[HttpPost]
		public async Task<IActionResult> Remove(string? doorId)
		{
			try
			{
				string? userId = this.GetUserId();

				if (userId == null)
				{
					return Forbid();
				}

				bool result = await this.wishlistService
					.RemoveDoorFromWishlistAsync(doorId, userId);

				if (result == false)
				{
					return this.RedirectToAction(nameof(Index), "Door");
				}

				return this.RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index), "Home");
			}
		}
	}
}
