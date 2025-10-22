namespace DoorsWebProject.Services.Core
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.EntityFrameworkCore;

	public class DoorService : IDoorService
	{
		private readonly IDoorRepository doorRepository;

		public DoorService(IDoorRepository doorRepository)
		{
			this.doorRepository = doorRepository;
		}

		public async Task<IEnumerable<AllDoorsIndexViewModel>> GetAllDoorsAsync()
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors =
				await this.doorRepository
				.GetAllAttached()
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
				Description = doorFormInputModel.Description,
				ImageUrl = doorFormInputModel.ImageUrl,
				Price = doorFormInputModel.Price,
				Height = doorFormInputModel.Height,
				Width = doorFormInputModel.Width,
				Thickness = doorFormInputModel.Thickness
			};

			await this.doorRepository.AddAsync(newDoor);
		}

		public async Task<bool> HardDeleteDoorAsync(string? id)
		{
			var door = await FindDoorByStringId(id);
			if (door == null)
			{
				return false;
			}

			await this.doorRepository.HardDeleteAsync(door);

			return true;
		}

		public async Task<bool> SoftDeleteDoorAsync(string? id)
		{
			var door = await FindDoorByStringId(id);
			if (door == null)
			{
				return false;
			}

			return await this.doorRepository.SoftDeleteAsync(door);
			
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
					door = await this.doorRepository
						.GetByIdAsync(idToGuid);
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

		public async Task<DoorDetailsViewModel?> GetDoorDetailsByIdAsync(string id)
		{
			var door = await doorRepository
				.GetAllAttached()
				.AsNoTracking()
				.FirstOrDefaultAsync(d => d.DoorId.ToString() == id && !d.IsDeleted);

			if(door == null)
			{
				return null;
			}

			return new DoorDetailsViewModel()
			{
				Id = door.DoorId.ToString(),
				ImageUrl = door.ImageUrl!,
				Model = door.Model,
				Description = door.Description,
				Material = door.Material,
				Height = door.Height.ToString(),
				Width = door.Width.ToString(),
				Thickness = door.Thickness.ToString()

			};
		}

		public async Task<IEnumerable<AllDoorsIndexViewModel>> GetAllFilteredDoorsAsync(string filter)
		{
			IEnumerable<AllDoorsIndexViewModel> allDoors =
				await this.doorRepository
				.GetAllAttached()
				.Where(d => d.Type == filter)
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

		public async Task<DoorFormInputModel?> GetEditableDoorByIdAsync(string id)
		{
			var door = await doorRepository
				.GetAllAttached()
				.AsNoTracking()
				.FirstOrDefaultAsync(d => d.DoorId.ToString() == id && !d.IsDeleted);

			if (door == null)
			{
				return null;
			}

			return new DoorFormInputModel()
			{
				ImageUrl = door.ImageUrl,
				Model = door.Model,
				Description = door.Description,
				Material = door.Material,
				Height = door.Height,
				Width = door.Width,
				Thickness = door.Thickness

			};
		}

		public async Task<bool> EditDoorAsync(DoorFormInputModel doorInputModel)
		{
			Door? editableDoor = await this.doorRepository
				.SingleOrDefaultAsync(d => d.DoorId.ToString() == doorInputModel.Id);

			if(editableDoor == null)
			{
				return false;
			}

			editableDoor.Model = doorInputModel.Model;
			editableDoor.Material = doorInputModel.Material;
			editableDoor.ImageUrl = doorInputModel.ImageUrl;
			editableDoor.Description = doorInputModel.Description;
			editableDoor.Price = doorInputModel.Price;
            editableDoor.Height = doorInputModel.Height;
			editableDoor.Width = doorInputModel.Width;
			editableDoor.Thickness = doorInputModel.Thickness;

			await this.doorRepository.UpdateAsync(editableDoor);

			return true;

		}

		public async Task<IEnumerable<AllDoorsIndexViewModel>> SearchingDoorsAsync(string? searchDoorsName)
		{
			IEnumerable<AllDoorsIndexViewModel> searchDoors = await this.doorRepository
				.GetAllAttached()
				.Where(d => !string.IsNullOrEmpty(searchDoorsName) && 
				  d.Model.Contains(searchDoorsName))
				.Select(d => new AllDoorsIndexViewModel
				{
					Id = d.DoorId.ToString(),
					Model = d.Model,
					ImageUrl = d.ImageUrl,
					Price = d.Price.ToString(),
				})
				.ToListAsync();

			return searchDoors;
		}

		
	}
}