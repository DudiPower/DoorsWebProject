namespace DoorsWebProject.Services.Core.Interfaces
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Web.ViewModels.Door;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public interface IDoorService
	{
		Task<IEnumerable<AllDoorsIndexViewModel>> GetAllDoorsAsync();

		Task CreateDoorAsync(DoorFormInputModel doorFormInputModel);

		Task <DoorDetailsViewModel?> GetDoorDetailsByIdAsync(string id);
		Task<bool> HardDeleteDoorAsync(string? id);

		Task<bool> SoftDeleteDoorAsync(string? id);

		Task<IEnumerable<AllDoorsIndexViewModel>> GetAllFilteredDoorsAsync(string filter);

		Task<DoorFormInputModel?> GetEditableDoorByIdAsync(string id);

		Task<bool> EditDoorAsync(DoorFormInputModel doorFormInputModel);
		Task<DoorDeleteViewModel?> GetDoorDeleteDetailsById(string? id);
		Task<Door?> FindDoorByStringId(string? id);

		Task<IEnumerable<AllDoorsIndexViewModel>> SearchingDoorsAsync(string? searchDoors);

		Task<bool> BuyDoor(string? id);

	}
}
