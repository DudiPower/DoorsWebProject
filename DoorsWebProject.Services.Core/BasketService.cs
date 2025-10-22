namespace DoorsWebProject.Services.Core
{
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketService : IBasketService
	{
		private readonly IBasketRepository basketRepository;
		public BasketService(IBasketRepository basketRepository)
		{
			this.basketRepository = basketRepository;
		}
		
	}
}
