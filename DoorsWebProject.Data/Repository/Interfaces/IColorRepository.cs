namespace DoorsWebProject.Data.Repository.Interfaces
{
	using DoorsWebProject.Data.Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IColorRepository : 
		IRepository<Color, Guid> , IAsyncRepository<Color , Guid>
	{
	}
}
