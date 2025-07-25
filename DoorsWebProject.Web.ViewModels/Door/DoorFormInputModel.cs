namespace DoorsWebProject.Web.ViewModels.Door
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using static DoorsWebProject.Data.Common.EntityConstants.Door;
	using static DoorsWebProject.Web.ViewModels.ValidationMessages;
	
	public class DoorFormInputModel
	{
		public string Id { get; set; }

		[Required(ErrorMessage = ModelRequiredMessage)]
		[MinLength(DoorModelMinLength, ErrorMessage = ModelMinLengthMessage)]
		[MaxLength(DoorModelMaxLength, ErrorMessage = ModelMaxLengthMessage)]
		public string Model { get; set; } = null!;

		[Required(ErrorMessage = MaterialRequiredMessage)]
		[MinLength(DoorMaterialMinLength, ErrorMessage = MaterialMinLengthMessage)]
		[MaxLength(DoorMaterialMaxLength, ErrorMessage = MaterialMaxLengthMessage)]
		public string Material { get; set; } = null!;

		[Required(ErrorMessage = DescriptionRequiredMessage)]
		[MinLength(DoorDescriptionMinLength, ErrorMessage = DescriptionMinLengthMessage)]
		[MaxLength(DoorDescriptionMaxLength, ErrorMessage = DescriptionMaxLengthMessage)]
		public string Description { get; set; } = null!;

		[MaxLength(DoorImageUrlMaxLength , ErrorMessage = ImageUrlMaxLengthMessage)]
		public string? ImageUrl { get; set; } 


		[Required(ErrorMessage = PriceRequiredMessage)]
		[Range(typeof(decimal), DoorPriceMinLengthString, DoorPriceMaxLengthString, ErrorMessage = PriceRangeMessage)]


		public decimal Price { get; set; }

		[Required(ErrorMessage = HeightRequiredMessage)]
		[Range(typeof(decimal), DoorHeightMinLengthString, DoorHeightMaxLengthString , ErrorMessage = HeightRangeMessage)]
		public decimal Height { get; set; }

		[Required(ErrorMessage = WidthRequiredMessage)]
		[Range(typeof(decimal) ,DoorWidthMinLengthString, DoorWidthMaxLengthString, ErrorMessage = WidthRangeMessage)]
		public decimal Width { get; set; }

		[Required(ErrorMessage = ThicknessRequiredMessage)]
		[Range(typeof(decimal), DoorThicknessMinLengthString ,DoorThicknessMaxLengthString, ErrorMessage = ThicknessRangeMessage)]
		public decimal Thickness { get; set; }
	}
}
