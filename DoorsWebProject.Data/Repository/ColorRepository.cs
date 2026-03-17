namespace DoorsWebProject.Data.Repository
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ColorRepository : BaseRepository<Color, Guid> , IColorRepository
	{
		public ColorRepository(DoorsDbContext dbContext)
			: base(dbContext)
		{

		}
	}
}
