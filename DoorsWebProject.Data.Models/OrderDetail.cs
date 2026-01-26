namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class OrderDetail
	{
		public Guid OrderDetailId { get; set; } = Guid.NewGuid();

		public Guid OrderId { get; set; }

		public Order Order { get; set; }
		public Guid DoorId { get; set; }

		public Door Door { get; set; }
		public int Quantity { get; set; }
		public double UnitPrice { get; set; }
		
	}
}
