namespace DoorsWebProject.Web.Controllers
{
	using AspNetCoreGeneratedDocument;
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.Session;
	using DoorsWebProject.Web.ViewModels.Basket;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.EntityFrameworkCore.Diagnostics;
	using System;
	using System.Threading.Tasks;

	public class BasketController : BaseController
	{
		private readonly IBasketService basketService;
		private const string basketSessionKey = "basketId";

		public BasketController(IBasketService basketService)
		{
			this.basketService = basketService;
		}

		

		

		




	}
}
