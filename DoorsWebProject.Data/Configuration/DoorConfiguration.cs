using DoorsWebProject.Data.Models;

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
				.HasOne(d => d.User)
				.WithMany(au => au.Doors)
				.HasForeignKey(d => d.ApplicationUserId);

			builder
				.HasQueryFilter(d => d.IsDeleted == false);


		}
	}
};



//		public List<Door> SeedDoors()
//		{
//			List<Door> list = new List<Door>()
//			{
//				new Door
//				{
//					DoorId = Guid.Parse("11111111-aaaa-4bbb-cccc-000000000002"),
//					Model = "S200",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-steel-door.webp",
//					Type = "Smooth",
//					Description = "Smooth steel door with minimalist style.",
//					Price = 529.99m,
//					Height = 210.0m,
//					Width = 95.0m,
//					Thickness = 4.0m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("22222222-bbbb-4ccc-dddd-000000000003"),
//					Model = "S250",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-2.webp",
//					Type = "Smooth",
//					Description = "Smooth steel door, ideal for modern apartments.",
//					Price = 489.99m,
//					Height = 205.0m,
//					Width = 92.0m,
//					Thickness = 4.2m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("33333333-cccc-4ddd-eeee-000000000004"),
//					Model = "S300",
//					Material = "Aluminium",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-aluminium.webp",
//					Type = "Smooth",
//					Description = "Smooth aluminium door with matte finish.",
//					Price = 549.99m,
//					Height = 200.0m,
//					Width = 88.0m,
//					Thickness = 3.8m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("44444444-dddd-4eee-ffff-000000000005"),
//					Model = "P100",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-steel-door.webp",
//					Type = "Profiled",
//					Description = "Profiled steel door with decorative panels.",
//					Price = 599.99m,
//					Height = 215.0m,
//					Width = 96.0m,
//					Thickness = 4.5m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("55555555-eeee-4fff-aaaa-000000000006"),
//					Model = "P150",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-2.webp",
//					Type = "Profiled",
//					Description = "Profiled steel door with elegant frame.",
//					Price = 569.99m,
//					Height = 210.0m,
//					Width = 94.0m,
//					Thickness = 4.3m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("66666666-ffff-4aaa-bbbb-000000000007"),
//					Model = "P200",
//					Material = "Wood",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-wood.webp",
//					Type = "Profiled",
//					Description = "Profiled wooden door with traditional design.",
//					Price = 649.99m,
//					Height = 205.0m,
//					Width = 90.0m,
//					Thickness = 4.0m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("77777777-aaaa-4bbb-cccc-000000000008"),
//					Model = "P250",
//					Material = "Aluminium",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-aluminium.webp",
//					Type = "Profiled",
//					Description = "Profiled aluminium door with brushed surface.",
//					Price = 589.99m,
//					Height = 200.0m,
//					Width = 88.0m,
//					Thickness = 3.7m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("88888888-bbbb-4ccc-dddd-000000000009"),
//					Model = "G100",
//					Material = "Steel + Glass",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-glazed-steel-door.webp",
//					Type = "Glazed",
//					Description = "Glazed steel door with tempered glass panel.",
//					Price = 699.99m,
//					Height = 215.0m,
//					Width = 98.0m,
//					Thickness = 4.8m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("99999999-cccc-4ddd-eeee-000000000010"),
//					Model = "G150",
//					Material = "Steel + Glass",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-glazed-2.webp",
//					Type = "Glazed",
//					Description = "Glazed steel door with frosted glass insert.",
//					Price = 729.99m,
//					Height = 210.0m,
//					Width = 94.0m,
//					Thickness = 4.5m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("aaaaaaaa-dddd-4eee-ffff-000000000011"),
//					Model = "G200",
//					Material = "Wood + Glass",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-glazed-wood.webp",
//					Type = "Glazed",
//					Description = "Glazed wooden door with decorative glass.",
//					Price = 759.99m,
//					Height = 205.0m,
//					Width = 92.0m,
//					Thickness = 4.2m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("bbbbbbbb-eeee-4fff-aaaa-000000000012"),
//					Model = "S350",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-lux.webp",
//					Type = "Smooth",
//					Description = "Smooth luxury steel door with premium coating.",
//					Price = 599.99m,
//					Height = 220.0m,
//					Width = 100.0m,
//					Thickness = 4.7m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("cccccccc-ffff-4aaa-bbbb-000000000013"),
//					Model = "P300",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-lux.webp",
//					Type = "Profiled",
//					Description = "Profiled steel door with ornate panel design.",
//					Price = 639.99m,
//					Height = 210.0m,
//					Width = 95.0m,
//					Thickness = 4.5m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("dddddddd-aaaa-4bbb-cccc-000000000014"),
//					Model = "G250",
//					Material = "Steel + Glass",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-glazed-modern.webp",
//					Type = "Glazed",
//					Description = "Modern glazed door with clear glass panel.",
//					Price = 749.99m,
//					Height = 215.0m,
//					Width = 96.0m,
//					Thickness = 4.6m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("eeeeeeee-bbbb-4ccc-dddd-000000000015"),
//					Model = "S400",
//					Material = "Aluminium",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-ultra.webp",
//					Type = "Smooth",
//					Description = "Ultra-smooth aluminium door for contemporary homes.",
//					Price = 559.99m,
//					Height = 205.0m,
//					Width = 93.0m,
//					Thickness = 4.0m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("ffffffff-cccc-4ddd-eeee-000000000016"),
//					Model = "P350",
//					Material = "Wood",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-classic.webp",
//					Type = "Profiled",
//					Description = "Classic profiled wooden door with deep carvings.",
//					Price = 689.99m,
//					Height = 215.0m,
//					Width = 98.0m,
//					Thickness = 4.4m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("12345678-dddd-4eee-ffff-000000000017"),
//					Model = "G300",
//					Material = "Aluminium + Glass",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-glazed-lux.webp",
//					Type = "Glazed",
//					Description = "Luxury glazed aluminium door with tinted glass.",
//					Price = 799.99m,
//					Height = 220.0m,
//					Width = 100.0m,
//					Thickness = 4.9m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("23456789-eeee-4fff-aaaa-000000000018"),
//					Model = "S450",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-secure.webp",
//					Type = "Smooth",
//					Description = "Smooth steel door with advanced security locks.",
//					Price = 629.99m,
//					Height = 210.0m,
//					Width = 95.0m,
//					Thickness = 4.6m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("34567890-ffff-4aaa-bbbb-000000000019"),
//					Model = "P400",
//					Material = "Steel",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-profiled-secure.webp",
//					Type = "Profiled",
//					Description = "Profiled steel door reinforced for extra security.",
//					Price = 669.99m,
//					Height = 210.0m,
//					Width = 94.0m,
//					Thickness = 4.5m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("45678901-aaaa-4bbb-cccc-000000000020"),
//					Model = "G350",
//					Material = "Steel + Glass",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-glazed-secure.webp",
//					Type = "Glazed",
//					Description = "Secure glazed steel door with impact-resistant glass.",
//					Price = 789.99m,
//					Height = 215.0m,
//					Width = 97.0m,
//					Thickness = 4.8m
//				},
//				new Door
//				{
//					DoorId = Guid.Parse("56789012-bbbb-4ccc-dddd-000000000021"),
//					Model = "S500",
//					Material = "Aluminium",
//					ImageUrl = "https://starkdoor.com/external/public_html/images/categories/stark-smooth-eco.webp",
//					Type = "Smooth",
//					Description = "Eco-friendly smooth aluminium door with insulation.",
//					Price = 579.99m,
//					Height = 205.0m,
//					Width = 92.0m,
//					Thickness = 4.1m
//				}
//			};


//			return list;
//		}

//	}
//}
