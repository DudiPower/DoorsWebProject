namespace DoorsWebProject.Services.Core.Interfaces
{
	using DoorsWebProject.Web.ViewModels.Wishlist;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IWishlistService
	{
		Task<IEnumerable<WishlistViewModel>> GetWishlistDoorsAsync(string userId);

		Task<bool> AddDoorToWishlistAsync (string? doorId , string? userId);

		Task<bool> RemoveDoorFromWishlistAsync(string? doorId, string? userId);

		//Task<bool> IsDoorAddedToWishlistAsync(string? doorId, string? userId);
	}
}
