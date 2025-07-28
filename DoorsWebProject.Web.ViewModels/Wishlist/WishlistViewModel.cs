namespace DoorsWebProject.Web.ViewModels.Wishlist
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class WishlistViewModel
	{
		public string Id { get; set; } = null!;

		public string Model { get; set; } = null!;

		public string? ImageUrl { get; set; }
	
		public string Price { get; set; } = null!;
	}
}
