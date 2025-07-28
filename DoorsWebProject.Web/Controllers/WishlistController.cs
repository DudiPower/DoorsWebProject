namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Web.ViewModels.Wishlist;
	using Microsoft.AspNetCore.Mvc;

	public class WishlistController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			IEnumerable<WishlistViewModel> emptyDoorList = 
				new List<WishlistViewModel>();
			return View(emptyDoorList);
		}
	}
}
