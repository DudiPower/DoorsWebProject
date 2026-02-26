namespace DoorsWebProject.Web.Areas.Admin.Controllers
{
	using DoorsWebProject.Services.Core.Admin.Interfaces;
	using DoorsWebProject.Web.ViewModels.Admin.Door;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

	[Area("Admin")]
	public class AdminDoorController : BaseAdminController
	{

		private readonly IAdminDoorService doorService;

		public AdminDoorController(IAdminDoorService doorService)
		{
			this.doorService = doorService;
		}
		public async Task<IActionResult> Index()
		{
			IEnumerable<DoorAdminViewModel> doorAdmins = await doorService
				.ReturnDoorAdminInTableView();


			return View(doorAdmins);
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

		[IgnoreAntiforgeryToken]
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
		public async Task<IActionResult> Edit(string? id)
		{
			FindedDoorViewModel findedDoor = await this.doorService
				.FindDoorByStringId(id);

			if(findedDoor == null)
			{
				return this.RedirectToAction(nameof(Index));
			}

			return this.View(findedDoor);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(FindedDoorViewModel inputDoorModel)
		{ 

			if (!this.ModelState.IsValid)
			{
				foreach (var kvp in ModelState)
				{
					foreach (var err in kvp.Value.Errors)
					{
						Console.WriteLine($"{kvp.Key} -> {err.ErrorMessage}");
					}
				}

				return this.View(inputDoorModel);
			}

			try
			{
				bool editSuccess = await this.doorService.EditDoorAsync(inputDoorModel);

				if (!editSuccess)
				{
					return this.RedirectToAction(nameof(Index));
				}

				return this.RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);

				return this.RedirectToAction(nameof(Index));
			}
		}

	}
}
