namespace DoorsWebProject.Data.Repository.Interfaces
{
	using DoorsWebProject.Data.Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IBasketRepository
		: IRepository<Basket, Guid>, IAsyncRepository<Basket, Guid>
	{



	}
}
