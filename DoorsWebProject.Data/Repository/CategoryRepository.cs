namespace DoorsWebProject.Data.Repository
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using Microsoft.EntityFrameworkCore.Query.Internal;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class CategoryRepository : BaseRepository<Category , Guid> , ICategoryRepository
	{
		public CategoryRepository(DoorsDbContext dbContext)
			: base(dbContext)
		{
			
		}
	}
}
