namespace DoorsWebProject.Web.ViewModels.Admin.UserManagement
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class UserManagementIndexViewModel
	{
		public string Id { get; set; } = null!;
		public string Email { get; set; } = null!;

		public IEnumerable<string> Roles { get; set; } = null!;
	}
}
