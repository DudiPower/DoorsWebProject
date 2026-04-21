namespace DoorsWebProject.Web.ViewModels.Door
{
	using DoorsWebProject.Web.ViewModels.Color;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorDetailsViewModel
	{
		public string Id { get; set; } = null!;

		public string Model { get; set; } = null!;
		public string ImageUrl { get; set; } = null!;
		public string Type { get; set; } = null!;
		public string Description { get; set; } = null!;

		public decimal Height { get; set; } 

		public decimal Width { get; set; }

		public decimal Thickness { get; set; } 

		public ICollection<ColorViewModel> DoorColors { get; set; } =
			new HashSet<ColorViewModel>();
	}
}
