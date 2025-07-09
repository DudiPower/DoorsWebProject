namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Category
	{
		public Guid CategoryId { get; set; } = Guid.NewGuid();

		public string Name { get; set; } = null!;

		public bool IsDeleted { get; set; }

		public ICollection<DoorCategory> CategoryDoors { get; set; } =
			 new HashSet<DoorCategory>();
	
	}
}
