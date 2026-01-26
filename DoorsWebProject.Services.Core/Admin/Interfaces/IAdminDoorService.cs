namespace DoorsWebProject.Services.Core.Admin.Interfaces
{
	using DoorsWebProject.Web.ViewModels.Admin.Door;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IAdminDoorService
	{
		Task<IEnumerable<DoorAdminViewModel>> ReturnDoorAdminInTableView(string userId);
	}
}
