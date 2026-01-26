namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketDetail
	{
		public Guid BasketDetailId { get; set; } = Guid.NewGuid();

		public Guid BasketId {  get; set; }

		public Guid DoorId {  get; set; }

		public Door Door {  get; set; }
		public Basket Basket { get; set; }

		public int Quantity { get; set; }

		public decimal UnitPrice { get; set; }
	}
}
