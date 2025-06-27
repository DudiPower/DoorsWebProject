namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
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

		public async Task<IActionResult> Crete()
		{
			DoorFormInputModel model = await this.doorService
				.CreateDoorAsync();

			return View();
		}
	}
}
