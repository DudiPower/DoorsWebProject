namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorColor
	{
		public Guid DoorId { get; set; }

		public Door Door { get; set; } = null!;

		public Guid ColorId { get; set; }

		public Color Color { get; set; } = null!;
	}
}
