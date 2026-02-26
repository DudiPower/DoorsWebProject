namespace DoorsWebProject.Web.ViewModels.Admin.Door
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorAdminViewModel
	{
		public string Id { get; set; }
		public string ImageUrl { get; set; }
		public string Model { get; set; }
		public string Category { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
	}
}
