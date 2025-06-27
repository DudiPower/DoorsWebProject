namespace DoorsWebProject.Services.Core.Interfaces
{
	using DoorsWebProject.Web.ViewModels.Door;
	using DoorsWebProject.Web.ViewModels.Door;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public interface IDoorService
	{
		Task<IEnumerable<AllDoorsIndexViewModel>> GetAllDoorsAsync();

		Task CreateDoorAsync(DoorFormInputModel doorFormInputModel);
	}
}
