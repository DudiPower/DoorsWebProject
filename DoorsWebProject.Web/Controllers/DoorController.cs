namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Data;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.EntityFrameworkCore;
	using static DoorsWebProject.Web.ViewModels.ValidationMessages;
	public class DoorController : BaseController
	{

		private readonly IDoorService doorService;
		private readonly DoorsDbContext dbContext;

		public DoorController(IDoorService doorService, DoorsDbContext dbContext)
		{
			this.doorService = doorService;
			this.dbContext = dbContext;
		}
		[HttpGet]
		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors = await this.doorService
				.GetAllDoorsAsync() ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;

			return View(allDoors);
		}

		//[HttpGet]
		//public async Task<IActionResult> Create()
		//{

		//	return  this.View();
		//}

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
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

				this.ModelState.AddModelError(string.Empty, ServiceCreateError);
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

				return this.RedirectToAction(nameof(Index), "Home");
			}
		}

		[HttpGet]
		[AllowAnonymous]
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

		[AllowAnonymous]
		public async Task<IActionResult> Smooth()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors = await this.doorService
				.GetAllFilteredDoorsAsync("Smooth") ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;

			return View(allDoors);
		}

		[AllowAnonymous]
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

				return this.RedirectToAction(nameof(Details), new { id = doorInputModel.Id });
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index));
			}
		}

		public async Task<IActionResult> Search(string searchTerm)
		{
			IEnumerable<AllDoorsIndexViewModel> allSearchingDoors = await this.doorService
				.SearchingDoorsAsync(searchTerm) ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;

			return View(allSearchingDoors);
		}

		//[HttpGet]
		//public async Task<IActionResult> Filter(int? categoryId, string? color, decimal? minPrice, decimal? maxPrice)
		//{
		//	var query = dbContext.Doors.AsQueryable();

		//	if (categoryId.HasValue)
		//		query = query.Where(d => d.DoorCategories.Any(dc => dc.CategoryId.ToString() == categoryId.Value.ToString()));

		//	//if (!string.IsNullOrEmpty(color))
		//	//	query = query.Where(d => d.Color == color);

		//	if (minPrice.HasValue)
		//		query = query.Where(d => d.Price >= minPrice.Value);

		//	if (maxPrice.HasValue)
		//		query = query.Where(d => d.Price <= maxPrice.Value);

		//var doors = await query
		//.Select(d => new AllDoorsIndexViewModel
		//{
		//	Id = d.DoorId.ToString(),
		//	ImageUrl = d.ImageUrl,
		//	Model = d.Model,
		//	Price = d.Price.ToString("F2") // формат 2 знака след дес. запетая
		//})
		//.ToListAsync();


		//	return PartialView("PartialDoorView", doors);
		//}


	}
}