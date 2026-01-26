namespace DoorsWebProject.Web.ViewModels.Basket
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketViewModel
	{
		public int BasketId { get; set; }

		public List<BasketItemViewModel> doors { get; set; } 
			= new List<BasketItemViewModel>();

		public string BuyerId { get; set; }

		public decimal Total()
		{
			return Math.Round(doors.Sum(i => i.UnitPrice * i.Quantity), 2);
		}
	}

	
}
