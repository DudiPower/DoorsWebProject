namespace DoorsWebProject.Data.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Basket
	{
		[Key]
		public Guid BasketId { get; set; } = Guid.NewGuid(); 

		public ICollection<Door> Doors { get; set; } 
			= new List<Door>();
	}
}
