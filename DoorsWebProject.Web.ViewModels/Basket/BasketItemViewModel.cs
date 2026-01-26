namespace DoorsWebProject.Web.ViewModels.Basket
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketItemViewModel
	{
		public int Id { get; set; }

		public int DoorId { get; set; }

		public string DoorModel { get; set; } = null!;

		public decimal UnitPrice { get; set; }

		public decimal OldUnitPrice { get; set; }

		public int Quantity { get; set; }

		public string PictureUrl { get; set; }
	}
}
