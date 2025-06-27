namespace DoorsWebProject.Services.Core
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.EntityFrameworkCore;

	public class DoorService : IDoorService
	{
		private readonly DoorsDbContext doorsDbContext;

		public DoorService(DoorsDbContext doorsDbContext)
		{
			this.doorsDbContext = doorsDbContext;
		}

		public async Task<IEnumerable<AllDoorsIndexViewModel>> GetAllDoorsAsync()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors =
				await this.doorsDbContext
				.Doors
				.Select(d => new AllDoorsIndexViewModel()
				{
					Id = d.Id,
					Model = d.Model,
					Price = d.Price.ToString(),
				})
				.ToListAsync();

			return allDoors;
		}

		public async Task CreateDoorAsync(DoorFormInputModel doorFormInputModel)
		{
			Door newDoor = new Door
			{
				Model = doorFormInputModel.Model,
				Material = doorFormInputModel.Material,
				Price = doorFormInputModel.Price,
				Height = doorFormInputModel.Height,
				Width = doorFormInputModel.Width,
				Thickness = doorFormInputModel.Thickness
			};

			await this.doorsDbContext.Doors.AddAsync(newDoor);
			await this.doorsDbContext.SaveChangesAsync();
		}
	}
}