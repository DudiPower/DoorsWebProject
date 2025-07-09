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

			public const int DoorImageUrlMaxLength = 2048;

			public const int DoorDescriptionMinLength = 5;
			public const int DoorDescriptionMaxLength = 2500;

			public const int DoorPriceMinLength = 2;
			public const int DoorPriceMaxLength = 200;
			public const string DoorPriceMinLengthString = "2.00";
			public const string DoorPriceMaxLengthString = "10000.00";


			public const decimal DoorHeightMinLengthDecimal = 0.00m;
			public const decimal DoorHeightMaxLengthDecimal = 16000.00m;
			public const string DoorHeightMinLengthString = "0.00";
			public const string DoorHeightMaxLengthString = "16000.00";

			public const decimal DoorWidthMinLengthDecimal = 0.00m;
			public const decimal DoorWidthMaxLengthDecimal = 4000.00m;
			public const string DoorWidthMinLengthString = "0.00";
			public const string DoorWidthMaxLengthString = "4000.00";

			public const decimal DoorThicknessMinLengthDecimal = 0.00m;
			public const decimal DoorThicknessMaxLengthDecimal = 1000.00m;
			public const string DoorThicknessMinLengthString = "0.00";
			public const string DoorThicknessMaxLengthString = "1000.00";

		}

		public static class Category
		{
			public const int CategoryNameMinLength = 2;
			public const int CategoryNameMaxLength = 200;
		}

		public static class Color
		{
			public const int ColorNameMinLength = 2;
			public const int ColorNameMaxLength = 200;

			public const int HexCodeMinLength = 1;
			public const int HexCodeMaxLength = 330;
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
		public const string HeightRangeMessage = "Height is between 0.00 and 16000.00";

		public const string WidthRequiredMessage = "Width is required";
		public const string WidthRangeMessage = "Width is between 0.00 and 4000.00";

		public const string ThicknessRequiredMessage = "Thickness is required";
		public const string ThicknessRangeMessage = "Thickness is between 0.00 and 1000.00";

	}
}
