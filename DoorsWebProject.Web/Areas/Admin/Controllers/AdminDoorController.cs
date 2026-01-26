namespace DoorsWebProject.Web.Areas.Admin.Controllers
{
	using DoorsWebProject.Services.Core.Admin.Interfaces;
	using DoorsWebProject.Web.ViewModels.Admin.Door;
	using Microsoft.AspNetCore.Mvc;

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
				.ReturnDoorAdminInTableView(this.GetUserId());


			return View(doorAdmins);
		}
	}
}
