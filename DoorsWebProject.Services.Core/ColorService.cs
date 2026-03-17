namespace DoorsWebProject.Services.Core
{
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Color;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ColorService : IColorService
	{

		private readonly IColorRepository colorRepository;

		public ColorService(IColorRepository colorRepository)
		{
			this.colorRepository = colorRepository;
		}

		
	}
}
