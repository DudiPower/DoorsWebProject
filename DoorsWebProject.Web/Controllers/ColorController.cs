namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Color;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Mvc;

	public class ColorController : BaseController
	{

		private readonly IColorService colorService;

		public ColorController(IColorService colorService)
		{
			this.colorService = colorService;
		}
		
	}
}
