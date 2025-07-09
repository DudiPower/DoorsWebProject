namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Internal;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorWishlistConfiguration : IEntityTypeConfiguration<DoorWishlist>
	{
		public void Configure(EntityTypeBuilder<DoorWishlist> builder)
		{
			builder
				.HasKey(dw => new { dw.DoorId, dw.WishlistId });

			builder
				.HasOne(dw => dw.Door)
				.WithMany(d => d.DoorWishlists)
				.HasForeignKey(dw => dw.DoorId);

			builder
				.HasOne(dw => dw.Wishlist)
				.WithMany(w => w.WishlistDoors)
				.HasForeignKey(dw => dw.WishlistId);


		}
	}
}
