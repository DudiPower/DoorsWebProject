namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;

	public class WishlistConfiguration : IEntityTypeConfiguration<Wishlist>
	{
		public void Configure(EntityTypeBuilder<Wishlist> builder)
		{
			builder
				.HasKey(w => w.WishlistId);

			builder
				.Property(w => w.IsDeleted)
				.IsRequired()
				.HasDefaultValue(false);

			builder
				.HasOne(w => w.User)
				.WithMany()
				.HasForeignKey(w => w.UserId);

			//builder
			//	.HasData(this.SeedWishlist());
		}

		//public List<Wishlist> SeedWishlist()
		//{
		//	List<Wishlist> wishlists = new List<Wishlist>()
		//	{
		//		new Wishlist
		//	{
		//		WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000001")
		//	},
		//	new Wishlist
		//	{
		//		WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000002")
		//	},
		//	new Wishlist
		//	{
		//		WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000003")
		//	},
		//	new Wishlist
		//	{
		//		WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000004")
		//	},
		//	new Wishlist
		//	{
		//		WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000005")
		//	}
		//	};

		//	return wishlists;
		//}
	}
}
