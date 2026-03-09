namespace DoorsWebProject.Services.Core.Admin.Interfaces
{
	using DoorsWebProject.Web.ViewModels.Admin.Door;
	using DoorsWebProject.Web.ViewModels.Door;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IAdminDoorService
	{
		Task<IEnumerable<DoorAdminViewModel>> ReturnDoorAdminInTableView();

		Task<DoorDeleteViewModel?> GetDoorDeleteDetailsById(string id);

		Task<FindedDoorViewModel?> FindDoorByStringId(string doorId);

		Task<DoorDetailsViewModel?> GetDoorDetailsByIdAsync(string id);
		Task<bool> SoftDeleteDoorAsync(string? id);

		Task<bool> EditDoorAsync(FindedDoorViewModel doorInputModel);

		Task CreateDoorAsync(DoorFormInputModel doorFormInputModel);
	}
}
