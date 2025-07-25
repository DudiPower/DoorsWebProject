namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using static DoorsWebProject.Data.Common.EntityConstants.Door;
	public class Door
	{
		public Guid DoorId { get; set; } = Guid.NewGuid();
		public string Model { get; set; } = null!;

		public string Material { get; set; } = null!;
		public string? ImageUrl { get; set; }

		public string Type { get; set; } = null!;
		public string Description { get; set; } = null!;
		public decimal Price { get; set; }

		public decimal Height { get; set; }

		public decimal Width { get; set; }

		public decimal Thickness { get; set; }
		public bool IsDeleted { get; set; }

		public ICollection<DoorColor> DoorColors { get; set; } = 
			new HashSet<DoorColor>();
		public ICollection<DoorCategory> DoorCategories { get; set; } =
			 new HashSet<DoorCategory>();

		public ICollection<DoorBasket> DoorBaskets { get; set; } =
			 new HashSet<DoorBasket>();

		public ICollection<DoorWishlist> DoorWishlists { get; set; } =
			 new HashSet<DoorWishlist>();
	}
}
