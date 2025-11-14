namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class ApplicationUserDoorConfiguration : IEntityTypeConfiguration<ApplicationUserDoor>
	{
		public void Configure(EntityTypeBuilder<ApplicationUserDoor> builder)
		{

			// Define composite Primary key of the Mapping Entity
			builder
				.HasKey(aud => new { aud.ApplicationUserId, aud.DoorId });

			// Define required constraints for the ApplicationUserDoor , as it is type string
			builder
				.Property(aud => aud.ApplicationUserId)
				.IsRequired();

			// Define default value for soft-delete functionality
			builder
				.Property(aud => aud.IsDeleted)
				.HasDefaultValue(false);

			// Configure relation between ApplicationUserDoor and IdentityUser

			builder
				.HasOne(aud => aud.ApplicationUser)
				.WithMany(au => au.WishlistDoors)
				.HasForeignKey(aud => aud.ApplicationUserId)
				.OnDelete(DeleteBehavior.Restrict);

			// Configure relation between ApplicationUserDoor and Door
			builder
				.HasOne(aud => aud.Door)
				.WithMany(d => d.UserWishlists)
				.HasForeignKey(aud => aud.DoorId)
				.OnDelete(DeleteBehavior.Restrict);

			// Define query filter to hide ApplicationUserDoor entries referring deleted Door 
			builder
				.HasQueryFilter(aud => aud.Door.IsDeleted == false);

			// Define query filter to hide the deleted entries in the user Wishlist 
			builder
				.HasQueryFilter(aud => aud.IsDeleted == false);
		}
	}
}
