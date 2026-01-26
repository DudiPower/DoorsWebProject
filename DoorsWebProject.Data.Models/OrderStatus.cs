namespace DoorsWebProject.Data.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class OrderStatus
	{
		public Guid OrderStatusId { get; set; }

		public string ?StatusName { get; set; }
	}
}
