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

		[HttpGet]
		public async Task<IActionResult> Create()
		{

			return this.View();
		}

		[HttpGet]
		public async Task<IActionResult> Delete(string? id)
		{
			try
			{
				DoorDeleteViewModel? doorToBeDelated = await this.doorService
				.GetDoorDeleteDetailsById(id);

				if (doorToBeDelated == null)
				{
					return this.RedirectToAction(nameof(Index));
				}

				return this.View(doorToBeDelated);
			}
			catch (Exception e) 
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index));
			}
			
		}


		[HttpPost]
		public async Task<IActionResult> Delete(DoorDeleteViewModel inputModel)
		{
			try
			{
				bool isDeletedCorrect = await this.doorService
				.HardDeleteDoorAsync(inputModel.Id);

				if (isDeletedCorrect)
				{
					return this.RedirectToAction(nameof(Index));
				}

				return this.RedirectToAction(nameof(Index));
			}
			catch (Exception e) 
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index) , "Home");
			}
		}

		public async Task<IActionResult> Details(string id)
		{
			try
			{
				DoorDetailsViewModel? door = await doorService
					.GetDoorDetailsByIdAsync(id);

				if (door == null)
				{
					return this.RedirectToAction(nameof(Index));
				}

				return this.View(door);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index));
			}
		} 
	}
}
