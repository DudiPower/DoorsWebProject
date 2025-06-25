namespace AspNetCoreArchTemplate.Web.ViewModels.Door
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class AllDoorsIndexViewModel
	{
		public Guid Id { get; set; } 

		public string Model { get; set; } = null!;

		public string Price { get; set; } = null!;
	}
}
