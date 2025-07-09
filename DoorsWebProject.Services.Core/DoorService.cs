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
					Id = d.DoorId.ToString(),
					ImageUrl = d.ImageUrl,
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

		public async Task<bool> HardDeleteDoorAsync(string? id)
		{
			var door = await FindDoorByStringId(id);
			if (door == null)
			{
				return false;
			}

			doorsDbContext.Doors.Remove(door);
			await doorsDbContext.SaveChangesAsync();

			return true;
		}

		public async Task<Door?> FindDoorByStringId(string? id)
		{
			Door? door = null;

			if (!string.IsNullOrWhiteSpace(id))
			{
				bool idIsValidToConvertToGuid = Guid
				.TryParse(id, out Guid idToGuid);

				if (idIsValidToConvertToGuid)
				{
					door = await this.doorsDbContext
						.Doors
						.FindAsync(idToGuid);
				}
			}

			return door;
		}

		public async Task<DoorDeleteViewModel?> GetDoorDeleteDetailsById(string? id)
		{
			DoorDeleteViewModel? deleteDoorViewModel = null;

			Door? door = await this.FindDoorByStringId(id);

			if (door != null) 
			{
				deleteDoorViewModel = new DoorDeleteViewModel()
				{
					Id = door.DoorId.ToString(),
					Model = door.Model,
					Price = door.Price,
				};
			}

			return deleteDoorViewModel;
		}

		public async Task<DoorDetailsViewModel> GetDoorDetailsByIdAsync(string id)
		{
			var door = await doorsDbContext
				.Doors
				.AsNoTracking()
				.FirstOrDefaultAsync(d => d.DoorId.ToString() == id && !d.IsDeleted);

			if(door == null)
			{
				return null;
			}

			return new DoorDetailsViewModel()
			{
				Id = door.DoorId.ToString(),
				ImageUrl = door.ImageUrl,
				Model = door.Model,
				Description = door.Description,
				Material = door.Material,
				Height = door.Height.ToString(),
				Width = door.Width.ToString(),
				Thickness = door.Thickness.ToString()

			};
		}
	}
}