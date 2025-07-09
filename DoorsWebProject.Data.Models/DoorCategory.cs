namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorCategory
	{
		public Guid DoorId { get; set; }

		public Door Door { get; set; } = null!;

		public Guid CategoryId { get; set; }

		public Category Category { get; set; } = null!;


	}
}
