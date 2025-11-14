namespace DoorsWebProject.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ApplicationUser : IdentityUser
	{
		public virtual ICollection<ApplicationUserDoor> WishlistDoors { get; set; } =
			new HashSet<ApplicationUserDoor>();

		public virtual ICollection<Door> Doors { get; set; } =
			new HashSet<Door>();
	}
}
