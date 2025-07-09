namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorBasket
	{
		public Guid DoorId { get; set; }

		public Door Door { get; set; } = null!;

		public Guid BasketId { get; set; }

		public Basket Basket { get; set; } = null!;
	}
}
