namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using static DoorsWebProject.Data.Common.EntityConstants.Door;

	public class DoorConfiguration : IEntityTypeConfiguration<Door>
	{
		public void Configure(EntityTypeBuilder<Door> builder)
		{
			builder
				.HasKey(d => d.DoorId);

			builder
				.Property(d => d.Model)
				.IsRequired()
				.HasMaxLength(DoorModelMaxLength);

			builder
				.Property(d => d.Material)
				.IsRequired()
				.HasMaxLength(DoorMaterialMaxLength);


			builder
				.Property(d => d.ImageUrl)
				.IsRequired(false)
				.HasMaxLength(DoorImageUrlMaxLength);

			builder
				.Property(d => d.Type)
				.IsRequired()
				.HasMaxLength(DoorTypeMaxLength);

			builder
				.Property(d => d.Description)
				.IsRequired()
				.HasMaxLength(DoorDescriptionMaxLength);

			builder
				.Property(d => d.Price)
				.IsRequired()
				.HasColumnType("decimal(18,2)");

			builder
				.Property(d => d.Height)
				.IsRequired()
				.HasColumnType("decimal(18,2)");

			builder
				.Property(d => d.Width)
				.IsRequired()
				.HasColumnType("decimal(18,2)");

			builder
				.Property(d => d.Thickness)
				.IsRequired()
				.HasColumnType("decimal(18,2)");

			builder
				.Property(d => d.IsDeleted)
				.IsRequired()
				.HasDefaultValue(false);


			builder
				.HasQueryFilter(d => d.IsDeleted == false);

			builder
				.HasData(this.SeedDoors());
		}

		public List<Door> SeedDoors()
		{
			List<Door> list = new List<Door>()
	{
		new Door
		{
			DoorId = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000001"),
			Model = "S100",
			Material = "Steel",
			ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-premium-steel-doors.webp",
			Type = "Solid",
			Description = "High-quality steel door with modern design.",
			Price = 499.99m,
			Height = 200.0m,
			Width = 90.0m,
			Thickness = 4.5m,
		},
		new Door
		{
			DoorId = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000002"),
			Model = "I200",
			Material = "Oak Wood",
			ImageUrl = "https://mla5dc5gjk9g.i.optimole.com/cb:ykaZ.3ba35/w:auto/h:auto/q:mauto/f:best/https://www.aspire-doors.co.uk/wp-content/uploads/2023/11/oak-mexicano-prefinished-lifestyle.jpg",
			Type = "Laminated",
			Description = "Elegant oak wood door with smooth finish.",
			Price = 299.00m,
			Height = 200.0m,
			Width = 80.0m,
			Thickness = 4.0m,
		},
		new Door
		{
			DoorId = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000003"),
			Model = "SL300",
			Material = "Tempered Glass",
			ImageUrl = "https://supplychaingamechanger.com/wp-content/uploads/2023/08/TemperedGlass.jpg",
			Type = "Laminated",
			Description = "Stylish tempered glass door with reinforced frame.",
			Price = 399.50m,
			Height = 210.0m,
			Width = 100.0m,
			Thickness = 3.5m,
		},
		new Door
		{
			DoorId = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000004"),
			Model = "F400",
			Material = "Steel with Fireproof Coating",
			ImageUrl = "https://5.imimg.com/data5/EM/DU/NC/SELLER-8174112/man-door-500x500.png",
			Type = "Solid",
			Description = "Fireproof steel door suitable for safety exits.",
			Price = 749.99m,
			Height = 210.0m,
			Width = 90.0m,
			Thickness = 5.0m,
		},
		new Door
		{
			DoorId = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000005"),
			Model = "E500",
			Material = "Aluminum",
			ImageUrl = "https://www.glenviewdoors.com/ExteriorAluminum/gallery/Swing-Aluminum-Exterior-Door-with-Sidelites-EAL-SWS-W6-2SL.jpg",
			Type = "PVC",
			Description = "Lightweight aluminum door with modern aesthetics.",
			Price = 599.00m,
			Height = 220.0m,
			Width = 100.0m,
			Thickness = 3.8m,
		}
	};

			return list;
		}
	}
}
