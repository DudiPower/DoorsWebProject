namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Color
	{

		[Key]
		public Guid ColorId { get; set; }

		[Required]
		public string NameColor { get; set; } = null!;

		[Required]

		public string HexCode { get; set; } = null!;

		public ICollection<Door> Doors { get; set; } = 
			  new List<Door>();
	}
}
