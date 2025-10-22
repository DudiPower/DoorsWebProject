namespace DoorsWebProject.Web.Controllers
{
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.Session;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;

	public class BasketController : BaseController
	{
		private readonly DoorsDbContext doorsDbContext;
		

		public BasketController(DoorsDbContext doorsDbContext)
		{
			this.doorsDbContext = doorsDbContext;
		}
		public IActionResult Index()
		{
			return View();
		}


		

	}
}
