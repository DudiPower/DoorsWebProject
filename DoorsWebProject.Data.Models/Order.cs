namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class Order
	{
		public Guid OrderId { get; set; } = Guid.NewGuid();

		public string ApplicationUserId { get; set; }

		public DateTime CreateDate { get; set; }

		public Guid OrderStatusId {  get; set; }

		public bool IsDeleted { get; set; }
		public OrderStatus OrderStatus { get; set; }

		public List<OrderDetail> OrderDetail { get; set; }

	}
}
