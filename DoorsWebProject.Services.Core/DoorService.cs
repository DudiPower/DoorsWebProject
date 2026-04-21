namespace DoorsWebProject.Services.Core
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using DoorsWebProject.Data;
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Data.Repository.Interfaces;
	using DoorsWebProject.Services.Core.Interfaces;
	using DoorsWebProject.Web.ViewModels.Color;
	using DoorsWebProject.Web.ViewModels.Door;
	using Microsoft.EntityFrameworkCore;

	public class DoorService : IDoorService
	{
		private readonly IDoorRepository doorRepository;

		public DoorService(IDoorRepository doorRepository)
		{
			this.doorRepository = doorRepository;
		}

		public async Task<IEnumerable<DoorViewModel>> GetAllDoorsAsync()
		{
			IEnumerable<DoorViewModel> allDoors =
				await this.doorRepository
				.GetAllAttached()
				.Take(4)
				.Select(d => new DoorViewModel()
				{
					Id = d.DoorId.ToString(),
					ImageUrl = d.ImageUrl,
					Model = d.Model,
					Price = d.Price,
				})
				.ToListAsync();

			return allDoors;
		}

		//public async Task<IEnumerable<DoorDetailsViewModel>> GetAllDoorsWithColorAsync()
		//{
		//	IEnumerable<DoorDetailsViewModel> allDoors =
		//		await this.doorRepository
		//		.GetAllAttached()
		//		.Select(d => new DoorDetailsViewModel()
		//		{
		//			Id = d.DoorId.ToString(),
		//			ImageUrl = d.ImageUrl,
		//			Model = d.Model,
		//			Description = d.Description,
		//			Height = d.Height.ToString(),
		//			Width = d.Width.ToString(),
		//			Thickness = d.Thickness.ToString(),
		//			DoorColors = d.DoorColors
		//			   .Select(dc => new ColorViewModel
		//			   {
		//				   Id = dc.ColorId.ToString(),
		//				   NameColor = dc.Color.NameColor,
		//				   HexCode = dc.Color.HexCode,
		//				   TextureUrl = dc.Color.TextureUrl
		//			   })
		//			   .ToArray()

		//		})
		//		.ToListAsync();

		//	return allDoors;
		//}

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
				.Include(d => d.DoorColors)
		        .ThenInclude(dc => dc.Color)
				.AsNoTracking()
				.FirstOrDefaultAsync(d => d.DoorId.ToString() == id && !d.IsDeleted);

			if(door == null)
			{
				return null;
			}

			DoorDetailsViewModel doorDetailsViewModel = null;

			doorDetailsViewModel = new DoorDetailsViewModel()
			{
				Id = door.DoorId.ToString(),
				ImageUrl = door.ImageUrl!,
				Model = door.Model,
				Description = door.Description,
				Height = door.Height,
				Width = door.Width,
				Thickness = door.Thickness,
				DoorColors = door.DoorColors
				  .Select(dc => new ColorViewModel()
				  {
					  Id = dc.ColorId.ToString(),
					  NameColor = dc.Color.NameColor,
					  HexCode = dc.Color.HexCode,
					  TextureUrl = dc.Color.TextureUrl
				  })
				  .ToArray()
			};

			return doorDetailsViewModel;
		}

		public async Task<IEnumerable<DoorViewModel>> GetAllFilteredDoorsAsync(string filter)
		{
			IEnumerable<DoorViewModel> allDoors =
				await this.doorRepository
				.GetAllAttached()
				.Where(d => d.Type == filter)
				.Select(d => new DoorViewModel()
				{
					Id = d.DoorId.ToString(),
					ImageUrl = d.ImageUrl,
					Model = d.Model,
					Price = d.Price,
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
			editableDoor.ImageUrl = doorInputModel.ImageUrl;
			editableDoor.Description = doorInputModel.Description;
			editableDoor.Price = doorInputModel.Price;
            editableDoor.Height = doorInputModel.Height;
			editableDoor.Width = doorInputModel.Width;
			editableDoor.Thickness = doorInputModel.Thickness;

			await this.doorRepository.UpdateAsync(editableDoor);

			return true;

		}

		public async Task<IEnumerable<DoorViewModel>> SearchingDoorsAsync(string? searchDoorsName)
		{
			IEnumerable<DoorViewModel> searchDoors = await this.doorRepository
				.GetAllAttached()
				.Where(d => !string.IsNullOrEmpty(searchDoorsName) && 
				  d.Model.Contains(searchDoorsName))
				.Select(d => new DoorViewModel
				{
					Id = d.DoorId.ToString(),
					Model = d.Model,
					ImageUrl = d.ImageUrl,
					Price = d.Price,
				})
				.ToListAsync();

			return searchDoors;
		}

		public async Task<bool> BuyDoor(string? id)
		{
			bool IdCanBeGuid = Guid.TryParse(id, out Guid guidId);

			var door = await this.doorRepository
				.GetByIdAsync(guidId);

			return true;
		}
	}
}