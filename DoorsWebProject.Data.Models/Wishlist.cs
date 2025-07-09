namespace DoorsWebProject.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Wishlist
	{
		[Key]
		public Guid WishlistId { get; set; } = Guid.NewGuid();

		public string UserId { get; set; } = null!;

		public IdentityUser User { get; set; } = null!;

		public bool IsDeleted { get; set; }

		public ICollection<DoorWishlist> WishlistDoors { get; set; } = 
			 new HashSet<DoorWishlist>();
	}
}
