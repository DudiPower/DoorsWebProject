namespace DoorsWebProject.Data.Common
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public static class EntityConstants
	{
		public static class Door
		{
			public const int DoorModelMinLength = 2;
			public const int DoorModelMaxLength = 200;

			public const int DoorMaterialMinLength = 2;
			public const int DoorMaterialMaxLength = 200;


			public const int DoorPriceMinLength = 2;
			public const int DoorPriceMaxLength = 200;
			public const string DoorPriceMinLengthString = "2.00";
			public const string DoorPriceMaxLengthString = "10000.00";


			public const double DoorSizeMinLengthDouble = 0.00;
			public const double DoorSizeMaxLengthDouble = 160.00;
		}

		public static class Category
		{
			public const int CategoryNameMinLength = 2;
			public const int CategoryNameMaxLength = 200;
		}

		public const string ModelRequiredMessage = "Model is required";
		public const string ModelMinLengthMessage = "Model must be at least 2 characters";
		public const string ModelMaxLengthMessage = "Model cannot exceed 200 characters";

		public const string MaterialRequiredMessage = "Material is required";
		public const string MaterialMinLengthMessage = "Material must be at least 2 characters";
		public const string MaterialMaxLengthMessage = "Material cannot exceed 200 characters";

		public const string PriceRequiredMessage = "Price is required";
		public const string PriceRangeMessage = "Price is between 2.00 and 10000.00";

		public const string HeightRequiredMessage = "Height is required";
		public const string HeightRangeMessage = "Height is between 0.00 and 160.00";

		public const string WidthRequiredMessage = "Width is required";
		public const string WidthRangeMessage = "Width is between 0.00 and 160.00";

		public const string ThicknessRequiredMessage = "Thickness is required";
		public const string ThicknessRangeMessage = "Thickness is between 0.00 and 160.00";

	}
}
