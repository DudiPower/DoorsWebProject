namespace DoorsWebProject.Web.ViewModels.Door
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Web.ViewModels.Color;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorViewModel
	{
		public string Id { get; set; } = null!;
		public string? ImageUrl { get; set; } 
		public string Model { get; set; } = null!;

		public decimal Price { get; set; }

	}
}
