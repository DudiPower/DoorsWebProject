namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using ViewModels;

	public class HomeController : BaseController
    {
		private readonly IDoorService doorService;

		public HomeController(IDoorService doorService)
		{
			this.doorService = doorService;
		}
		//public HomeController(ILogger<HomeController> logger)
  //      {

  //      }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
			IEnumerable<AllDoorsIndexViewModel> allDoors = await this.doorService
				.GetAllDoorsAsync() ?? Enumerable.Empty<AllDoorsIndexViewModel>(); ;

			return View(allDoors);
		}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
