namespace DoorsWebProject.Services.Core.Admin
{
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Admin.Interfaces;
	using DoorsWebProject.Web.ViewModels.Admin.Door;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Microsoft.EntityFrameworkCore;

	public class AdminDoorService : IAdminDoorService
	{
		private readonly IDoorRepository doorRepository;

		public AdminDoorService(IDoorRepository doorRepository)
		{
			this.doorRepository = doorRepository;
		}
		public async Task<IEnumerable<DoorAdminViewModel>> ReturnDoorAdminInTableView(string userId)
		{
			IEnumerable<DoorAdminViewModel> doorsAdmin = await doorRepository
				.GetAllAttached()
				.Where(d => d.ApplicationUserId == userId)
				.Select(d => new DoorAdminViewModel()
				{
					Id = d.DoorId,
					ImageUrl = d.ImageUrl,
					Model = d.Model,
					Category = d.DoorCategories
								 .Select(dc => dc.Category.Name)
								 .FirstOrDefault()!,
					Price = d.Price,
					Stock = 10,
				})
				.ToListAsync();

			return doorsAdmin;

		}
	}
}
