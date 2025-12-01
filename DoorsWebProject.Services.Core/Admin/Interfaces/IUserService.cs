namespace DoorsWebProject.Services.Core.Admin.Interfaces
{
	using DoorsWebProject.Web.ViewModels.Admin.UserManagement;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface IUserService
	{
		Task<IEnumerable<UserManagementIndexViewModel>> GetUserManagementBoardDataAsync(string userId);
	}
}
