namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Color
	{
		public Guid ColorId { get; set; }

		public string NameColor { get; set; } = null!;

		public string HexCode { get; set; } = null!;

		public bool IsDeleted { get; set; }

		public ICollection<DoorColor> ColorDoors { get; set; } = 
			  new HashSet<DoorColor>();
	}
}
