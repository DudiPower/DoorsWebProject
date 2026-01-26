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

	internal class BasketDetailConfiguration : IEntityTypeConfiguration<BasketDetail>
	{
		public void Configure(EntityTypeBuilder<BasketDetail> builder)
		{
			builder
				.Property(bd => bd.BasketId)
				.IsRequired();

			builder
				.Property(bd => bd.DoorId)
				.IsRequired();

			builder
				.Property(bd => bd.Quantity)
				.IsRequired();

			builder
	            .HasOne(bd => bd.Door)
	            .WithMany(d => d.BasketDetail)
	            .HasForeignKey(bd => bd.DoorId)
	            .OnDelete(DeleteBehavior.Restrict);
		}
	}
}
