namespace DoorsWebProject.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Basket
	{
		public Guid BasketId { get; set; } = Guid.NewGuid();

		public string UserId { get; set; } = null!;
		public IdentityUser User { get; set; } = null!;

		public bool IsDeleted { get; set; }

	}
}
