namespace DoorsWebProject.Services.Core.Admin
{
	using DoorsWebProject.Data.Models;
	using DoorsWebProject.Services.Core.Admin.Interfaces;
	using DoorsWebProject.Web.ViewModels.Admin.UserManagement;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class UserService : IUserService
	{
		private readonly UserManager<ApplicationUser> userManager;

		public UserService(UserManager<ApplicationUser> userManager)
		{
			this.userManager = userManager;
		}
		public async Task<IEnumerable<UserManagementIndexViewModel>> GetUserManagementBoardDataAsync(string userId)
		{
			IEnumerable<UserManagementIndexViewModel> users = await this.userManager
				.Users
				.Where(u => u.Id.ToLower() != userId.ToLower())
				.Select(u => new UserManagementIndexViewModel
				{
					Id = u.Id,
					Email = u.Email,
					Roles = userManager.GetRolesAsync(u)
						.GetAwaiter()
						.GetResult()
				})
				.ToArrayAsync();

			return users;
		}
	}
}
