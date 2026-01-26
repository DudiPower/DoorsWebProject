namespace DoorsWebProject.Services.Core
{
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Basket;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketService : IBasketService
	{
		private readonly IBasketRepository basketRepository;
		private readonly IDoorRepository doorRepository;
		public BasketService(IBasketRepository basketRepository, 
			IDoorRepository doorRepository)
		{
			this.basketRepository = basketRepository;
			this.doorRepository = doorRepository;
		}

		public Task AddDoorToBasket(int basketId, int doorId, decimal price, int quantity)
		{
			throw new NotImplementedException();
		}

		

	}
}
