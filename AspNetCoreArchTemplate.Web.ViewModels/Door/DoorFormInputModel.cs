namespace DoorsWebProject.Web.ViewModels.Door
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using static DoorsWebProject.Data.Common.EntityConstants.Door;
	using static DoorsWebProject.Data.Common.EntityConstants;
	public class DoorFormInputModel
	{
		[Required(ErrorMessage = ModelRequiredMessage)]
		[MinLength(DoorModelMinLength , ErrorMessage = ModelMinLengthMessage)]
		[MaxLength(DoorModelMaxLength , ErrorMessage = ModelMaxLengthMessage)]
		public string Model { get; set; } = null!;

		[Required(ErrorMessage = MaterialRequiredMessage)]
		[MinLength(DoorMaterialMinLength , ErrorMessage = MaterialMinLengthMessage)]
		[MaxLength(DoorMaterialMaxLength , ErrorMessage = MaterialMaxLengthMessage)]
		public string  Material { get; set; } = null!;

		[Required(ErrorMessage = PriceRequiredMessage)]
		[Range(typeof(decimal) , DoorPriceMinLengthString , DoorPriceMaxLengthString , ErrorMessage = PriceRangeMessage)]
		public decimal Price { get; set; }

		[Required(ErrorMessage = SizeRequiredMessage)]
		[Range(DoorSizeMinLengthDouble, DoorSizeMaxLengthDouble , ErrorMessage = SizeRangeMessage)]
		public double Size { get; set; } 
	}
}
