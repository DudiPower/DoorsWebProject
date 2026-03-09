namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using static DoorsWebProject.Data.Common.EntityConstants.Door;
	public class Door
	{
		public Guid DoorId { get; set; } = Guid.NewGuid();
		public string Model { get; set; } = null!;
		public string? ImageUrl { get; set; }

		public string Type { get; set; } = null!;
		public string? Description { get; set; } 
		public decimal Price { get; set; }

		public decimal Height { get; set; }

		public decimal Width { get; set; }

		public decimal Thickness { get; set; }
		public bool IsDeleted { get; set; }

		public string? ApplicationUserId { get; set; } 

		public virtual ApplicationUser? User { get; set; } 

		public List<OrderDetail> OrderDetail { get; set; }

		public List<BasketDetail> BasketDetail { get; set; }
		public ICollection<ApplicationUserDoor> UserWishlists { get; set; } = 
			new HashSet<ApplicationUserDoor>();
		public ICollection<DoorColor> DoorColors { get; set; } = 
			new HashSet<DoorColor>();
		public ICollection<DoorCategory> DoorCategories { get; set; } =
			 new HashSet<DoorCategory>();



	}
}
