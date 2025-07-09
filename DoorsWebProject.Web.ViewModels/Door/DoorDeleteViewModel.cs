namespace DoorsWebProject.Web.ViewModels.Door
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorDeleteViewModel
	{
		[Required]
		public string Id { get; set; } = null!;
		public string Model { get; set; } = null!;

		public decimal Price { get; set; }


	}
}
