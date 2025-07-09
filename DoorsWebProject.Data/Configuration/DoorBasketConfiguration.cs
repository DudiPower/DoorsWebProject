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

	public class DoorBasketConfiguration : IEntityTypeConfiguration<DoorBasket>
	{
		public void Configure(EntityTypeBuilder<DoorBasket> builder)
		{
			builder
				.HasKey(db => new { db.DoorId, db.BasketId });

			builder
				.HasOne(db => db.Door)
				.WithMany(d => d.DoorBaskets)
				.HasForeignKey(db => db.DoorId);

			builder
				.HasOne(db => db.Basket)
				.WithMany(b => b.BasketDoors)
				.HasForeignKey(db => db.BasketId);



		}
	}
}
