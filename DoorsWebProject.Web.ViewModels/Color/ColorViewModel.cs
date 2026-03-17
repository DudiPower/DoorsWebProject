namespace DoorsWebProject.Web.ViewModels.Color
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ColorViewModel
	{
		public string Id { get; set; } = null!;
		public string NameColor { get; set; } = null!;
		public string HexCode { get; set; } = null!;
		public string TextureUrl { get; set; } = null!;
	}
}
