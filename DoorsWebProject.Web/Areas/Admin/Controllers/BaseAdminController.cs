namespace DoorsWebProject.Web.Areas.Admin.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	using System.Security.Claims;
	using Microsoft.AspNetCore.Authorization;

	using static DoorsWebProject.GCommon.ApplicationConstants;

	[Area(AdminRoleName)]
	[Authorize(Roles = AdminRoleName)]
	public abstract class BaseAdminController : Controller
	{
		private bool IsUserAuthenticated()
		{
			bool retRes = false;
			if (this.User.Identity != null)
			{
				retRes = this.User.Identity.IsAuthenticated;
			}

			return retRes;
		}

		protected string? GetUserId()
		{
			string? userId = null;
			if (this.IsUserAuthenticated())
			{
				userId = this.User
					.FindFirstValue(ClaimTypes.NameIdentifier);
			}

			return userId;
		}
	}
}
