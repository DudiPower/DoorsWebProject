namespace DoorsWebProject.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	[Comment("User Watchlist entry in the system")]
	public class ApplicationUserDoor
	{
		[Comment("Foreign key to the referenced AspNetUser. Part of the entity composite PK")]
		public string ApplicationUserId { get; set; } = null!;

		public virtual ApplicationUser ApplicationUser { get; set; } = null!;

		[Comment("Foreign key to the referenced Door. Part of the entity composite PK")]
		public Guid DoorId { get; set; }

		public virtual Door Door { get; set; } = null!;

		[Comment("Show if ApplicationUserDoor entry is deleted")]
		public bool IsDeleted { get; set; }
	}
}
