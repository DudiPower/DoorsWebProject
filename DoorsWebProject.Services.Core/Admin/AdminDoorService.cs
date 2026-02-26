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
	using DoorsWebProject.Web.ViewModels.Door;
	using DoorsWebProject.Data.Models;

	public class AdminDoorService : IAdminDoorService
	{
		private readonly IDoorRepository doorRepository;

		public AdminDoorService(IDoorRepository doorRepository)
		{
			this.doorRepository = doorRepository;
		}
		public async Task<IEnumerable<DoorAdminViewModel>> ReturnDoorAdminInTableView()
		{
			IEnumerable<DoorAdminViewModel> doorsAdmin = await doorRepository
				.GetAllAttached()
				.Select(d => new DoorAdminViewModel()
				{
					Id = d.DoorId.ToString(),
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

		public async Task<DoorDeleteViewModel?> GetDoorDeleteDetailsById(string doorId)
		{

			DoorDeleteViewModel deletedDoor = null;

			FindedDoorViewModel searchedDoor = await
				this.FindDoorByStringId(doorId);

			if(searchedDoor != null)
			{
				deletedDoor = new DoorDeleteViewModel()
				{
					Id = searchedDoor.DoorId.ToString(),
					Model = searchedDoor.Model,
					Price = searchedDoor.Price,
				};
			}

			return deletedDoor;
		}

		public async Task<FindedDoorViewModel?> FindDoorByStringId(string doorId)
		{
			FindedDoorViewModel doorDeleteModel = null;

			

			if (!string.IsNullOrWhiteSpace(doorId))
			{
					doorDeleteModel = await doorRepository
					.GetAllAttached()
					//.Where(d => d.ApplicationUserId == doorId)
					.Select( d => new FindedDoorViewModel 
					{
						DoorId = d.DoorId,
						Model = d.Model ?? "",
						ImageUrl = d.ImageUrl,
						Type = d.Type ?? "",
						Description = d.Description,
						Price = d.Price,
						Height = d.Height,
						Width = d.Width,
						Thickness = d.Thickness
					})
					.FirstOrDefaultAsync();
				
			}
			 return doorDeleteModel;
			
		}

		public async Task<bool> SoftDeleteDoorAsync(string? id)
		{
			var door = await FindDoorByStringId(id);
			if (door == null)
			{
				return false;
			}

			var doorInDatabase = new Door()
			{
				DoorId = door.DoorId,
				Model = door.Model,
				Type = door.Type,
				Description = door.Description,
				Height = door.Height,
				Width = door.Width,
				Thickness = door.Thickness,
			
				ImageUrl = door.ImageUrl,
				Price = door.Price,
			};

			return await this.doorRepository.SoftDeleteAsync(doorInDatabase);

		}

		public async Task<bool> EditDoorAsync(FindedDoorViewModel doorInputModel)
		{
			Door? editableDoor = await this.doorRepository
				.SingleOrDefaultAsync(d => d.DoorId.ToString() == doorInputModel.DoorId.ToString());

			if (editableDoor == null)
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
	}
}
