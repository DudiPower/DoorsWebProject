namespace DoorsWebProject.Data.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Wishlist
	{
		[Key]
		public Guid WishlistId { get; set; } = Guid.NewGuid();

		[Required]
		public ICollection<Door> DoorList { get; set; } 
			= new HashSet<Door>();
	}
}
