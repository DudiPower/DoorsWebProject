namespace DoorsWebProject.Data.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Category
	{
		[Key]
		public Guid Id { get; set; } = Guid.NewGuid();

		[Required]
		[MaxLength(200)]
		public string Name { get; set; } = null!;


		public ICollection<Door> Doors { get; set; } = 
			 new List<Door>();
	}
}
