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

		public string Height { get; set; } = null!;

		public string Width { get; set; } = null!;

		public string Thickness { get; set; } = null!;

		public ICollection<ColorViewModel> DoorColors { get; set; } =
			new HashSet<ColorViewModel>();
	}
}
