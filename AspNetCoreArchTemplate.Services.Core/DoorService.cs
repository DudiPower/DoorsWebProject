namespace AspNetCoreArchTemplate.Services.Core
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AspNetCoreArchTemplate.Data;
	using AspNetCoreArchTemplate.Services.Core.Interfaces;
	using AspNetCoreArchTemplate.Web.ViewModels.Door;
	using DoorsWebProject.Data.Models;
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

		public Task CreateDoorAsync(DoorFormInputModel doorFormInputModel)
		{
			Door newDoor = new Door
			{
				Model = doorFormInputModel.Model,
				Material = doorFormInputModel.Material,
				Price = doorFormInputModel.Price,
				Size = doorFormInputModel.Size,
			};
		}
	}
}