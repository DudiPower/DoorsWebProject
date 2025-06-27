namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using static DoorsWebProject.Data.Common.EntityConstants.Door;
	public class Door
	{
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required]
		[MaxLength(DoorModelMaxLength)]
		public string Model { get; set; } = null!;

		[Required]
		[MaxLength(DoorMaterialMaxLength)]
		public string Material { get; set; } = null!;

		[Required]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal Price { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Height { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Width { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Thickness { get; set; }

		[Required]
        public Guid CategoryId { get; set; }

		public Category Category { get; set; } = null!;

		[Required]

		public Guid WishlistId { get; set; }

		public Wishlist Wishlist { get; set; } = null!;

		[Required]
		public Guid BasketId { get; set; }

		[ForeignKey(nameof(BasketId))]
		public Basket Basket { get; set; } = null!;

		public ICollection<Color> Colors { get; set; } = 
			 new List<Color>();
	}
}
