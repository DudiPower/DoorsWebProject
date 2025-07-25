namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Mvc;
	using static DoorsWebProject.Web.ViewModels.ValidationMessages;
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

		[HttpPost]
		public async Task<IActionResult> Create(DoorFormInputModel inputModel)
		{

			if (!this.ModelState.IsValid)
			{
				return this.View(inputModel);
			}

			try
			{
				await this.doorService.CreateDoorAsync(inputModel);

				return this.RedirectToAction(nameof(Index));
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);

				this.ModelState.AddModelError(string.Empty,ServiceCreateError);
				return this.View(inputModel);
			}
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
				.SoftDeleteDoorAsync(inputModel.Id);

				if (isDeletedCorrect == false)
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

		public async Task<IActionResult> Smooth()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors = await this.doorService
				.GetAllFilteredDoorsAsync("Laminated") ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;

			return View(allDoors);
		}

		public async Task<IActionResult> Glazed()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors = await this.doorService
				.GetAllFilteredDoorsAsync("Solid") ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;

			return View(allDoors);
		}

		[HttpGet]
		public async Task<IActionResult> Edit(string id)
		{
			try
			{
				DoorFormInputModel? editableMovie = await this.doorService
					.GetEditableDoorByIdAsync(id);

				if (editableMovie == null)
				{
					return this.RedirectToAction(nameof(Index));
				}

				return this.View(editableMovie);
			}
			catch (Exception e) 
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index));
			}
		}

		[HttpPost]

		public async Task<IActionResult> Edit(DoorFormInputModel doorInputModel)
		{
			if (!this.ModelState.IsValid)
			{
				return this.View(doorInputModel);
			}

			try
			{
				bool editSuccess = await this.doorService.EditDoorAsync(doorInputModel);

				if (!editSuccess) 
				{
					return this.RedirectToAction(nameof(Index));
				}

				return this.RedirectToAction(nameof(Details) , new { id = doorInputModel.Id });
			}
			catch (Exception e) 
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index));
			}
		}


	}
}
