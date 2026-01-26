namespace DoorsWebProject.Web.ViewModels.Door
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorItemViewModel
	{
		public int Id { get; set; }

		public string Model { get; set; }

		public string PictureUri { get; set; }
		public decimal Price { get; set; }
	}
}
