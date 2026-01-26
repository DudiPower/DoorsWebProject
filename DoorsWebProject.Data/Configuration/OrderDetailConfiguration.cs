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

	public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
	{
		public void Configure(EntityTypeBuilder<OrderDetail> builder)
		{
			builder
				.Property(od => od.OrderId)
				.IsRequired();

			builder
				.Property(od => od.DoorId)
				.IsRequired();

			builder
				.Property(od => od.Quantity)
				.IsRequired();

			builder
				.Property(od => od.UnitPrice)
				.IsRequired();
		}
	}
}
