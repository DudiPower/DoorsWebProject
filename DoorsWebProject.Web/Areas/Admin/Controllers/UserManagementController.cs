namespace DoorsWebProject.Web.Areas.Admin.Controllers
{
	using DoorsWebProject.Services.Core.Admin.Interfaces;
	using DoorsWebProject.Web.ViewModels.Admin.UserManagement;
	using Microsoft.AspNetCore.Mvc;
	using System.Threading.Tasks;

	public class UserManagementController : BaseAdminController
	{
		private readonly IUserService userService;

		public UserManagementController(IUserService userService)
		{
			this.userService = userService;
		}
		public async Task<IActionResult> Index()
		{
			IEnumerable<UserManagementIndexViewModel> allUsers = await this.userService
				.GetUserManagementBoardDataAsync(this.GetUserId()!);

			return View(allUsers);
		}
	}
}
