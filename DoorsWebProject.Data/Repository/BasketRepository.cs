namespace DoorsWebProject.Data.Repository
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class BasketRepository
		: BaseRepository<Basket, Guid> , IBasketRepository
	{
		public BasketRepository(DoorsDbContext dbContext)
			: base(dbContext) 
		{
			
		}

	}
}
