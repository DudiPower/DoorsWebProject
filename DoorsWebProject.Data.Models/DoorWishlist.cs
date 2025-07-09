namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorWishlist
	{
		public Guid DoorId { get; set; }

		public Door Door { get; set; } = null!;

		public Guid WishlistId { get; set; }

		public Wishlist Wishlist { get; set; } = null!;
	}
}
