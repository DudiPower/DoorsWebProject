namespace AspNetCoreArchTemplate.Web.Controllers
{
	using AspNetCoreArchTemplate.Services.Core.Interfaces;
	using AspNetCoreArchTemplate.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Mvc;

	public class DoorController : Controller
	{

		private readonly IDoorService doorService;

		public DoorController(IDoorService doorService)
		{
			this.doorService = doorService;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors = await this.doorService
				.GetAllDoorsAsync() ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;
			
			return View(allDoors);
		}
	}
}
