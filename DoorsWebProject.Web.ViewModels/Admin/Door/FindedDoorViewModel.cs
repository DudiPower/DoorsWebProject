namespace DoorsWebProject.Web.ViewModels.Admin.Door
{
	using DoorsWebProject.Data.Models;
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class FindedDoorViewModel
	{
		public Guid DoorId { get; set; } 

		[Required(ErrorMessage = "Model is required")]
		public string Model { get; set; } = null!; 
		public string? ImageUrl { get; set; }

		[Required(ErrorMessage = "Type is required")]
		public string Type { get; set; } = null!;
		public string? Description { get; set; }
		public decimal Price { get; set; } 

		public decimal Height { get; set; } 

		public decimal Width { get; set; } 

		public decimal Thickness { get; set; } 
	}
}
