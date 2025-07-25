namespace DoorsWebProject.Web.ViewModels
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ValidationMessages
	{
		public const string ModelRequiredMessage = "Model is required";
		public const string ModelMinLengthMessage = "Model must be at least 2 characters";
		public const string ModelMaxLengthMessage = "Model cannot exceed 200 characters";

		public const string MaterialRequiredMessage = "Material is required";
		public const string MaterialMinLengthMessage = "Material must be at least 2 characters";
		public const string MaterialMaxLengthMessage = "Material cannot exceed 200 characters";

		public const string ImageUrlMaxLengthMessage = "ImageUrl cannot exceed 2048 characters";

		public const string DescriptionRequiredMessage = "Description is required";
		public const string DescriptionMinLengthMessage = "Description must be at least 2 characters";
		public const string DescriptionMaxLengthMessage = "Description cannot exceed 1000 characters";

		public const string PriceRequiredMessage = "Price is required";
		public const string PriceRangeMessage = "Price is between 2.00 and 10000.00";

		public const string HeightRequiredMessage = "Height is required";
		public const string HeightRangeMessage = "Height is between 0.00 and 16000.00";

		public const string WidthRequiredMessage = "Width is required";
		public const string WidthRangeMessage = "Width is between 0.00 and 4000.00";

		public const string ThicknessRequiredMessage = "Thickness is required";
		public const string ThicknessRangeMessage = "Thickness is between 0.00 and 1000.00";

		public const string ServiceCreateError =
			"Fatal error occurred while adding your door! Please try again later!";
	}
}
