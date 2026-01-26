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

			//builder
			//	.HasData(SeedDoors());
				
		}

		public List<Door> SeedDoors()
		{
			List<Door> list = new List<Door>()
			{
				new Door
				{
					DoorId = Guid.Parse("40b2ed36-b35c-4016-b998-863038968490"),
					Model = "А-101 Африка",
					ImageUrl = "https://galiardi.biz/wp-content/uploads/2019/01/t-100-africa-01-940834835-450x450.png",
					Type = "Armored",
					Price = 890.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "b12cdb67-7ae7-4ae7-a7d0-22815749c41f"
				},
				new Door
				{
					DoorId = Guid.Parse("06ebf95c-7758-4ce2-afb3-191d3c57fe13"),
					Model = "А-102-Антик",
					ImageUrl = "https://galiardi.biz/wp-content/uploads/2019/01/t-100-antik-01-552213818-450x450.png",
					Type = "Armored",
					Price = 835.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "b12cdb67-7ae7-4ae7-a7d0-22815749c41f"
				},
				new Door
				{
					DoorId = Guid.Parse("55e5d4dc-a4fc-4fcd-aed1-4e688e63a547"),
					Model = "А-103-Орех",
					ImageUrl = "https://galiardi.biz/wp-content/uploads/2019/01/t-108-1228496364-450x450-300x300.png",
					Type = "Armored",
					Price = 800.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "bee1ccb1-7179-4d28-a154-2dbb5f88c189"
				},
				new Door
				{
					DoorId = Guid.Parse("eddf2e0d-ed9d-431b-90d1-8af284e5289b"),
					Model = "А-104-Спарта",
					ImageUrl = "https://galiardi.biz/wp-content/uploads/2019/01/t-110-sparta-01-450x450.png",
					Type = "Armored",
					Price = 870.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "bee1ccb1-7179-4d28-a154-2dbb5f88c189"
				},
				new Door
				{
					DoorId = Guid.Parse("e37f55fd-1f7b-40f2-9374-e881b95c4506"),
					Model = "А-105-Зебра",
					ImageUrl = "https://galiardi.biz/wp-content/uploads/2019/01/t-587-zebra-01-71555585-450x450.png",
					Type = "Armored",
					Price = 900.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "eef7fb7b-a155-419a-a7f7-6b6fc865ae03"
				},
				new Door
				{
					DoorId = Guid.Parse("ccc7397a-f7c6-46cd-9510-5dedb05a30f2"),
					Model = "W-239-Синитово",
					ImageUrl = "https://www.idialvrati.com/cache/images/4509.jpg",
					Type = "Wooden",
					Price = 2500.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},
				new Door
				{
					DoorId = Guid.Parse("c09bac80-7531-49b3-b147-b8e0377ad093"),
					Model = "W-238-Яна",
					ImageUrl = "https://www.idialvrati.com/cache/images/4559.jpg",
					Type = "Wooden",
					Price = 1200.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "eef7fb7b-a155-419a-a7f7-6b6fc865ae03"
				},

				new Door
				{
					DoorId = Guid.Parse("648047b3-6e61-4932-9f22-48792f58b911"),
					Model = "W-237-Лидия",
					ImageUrl = "https://www.idialvrati.com/cache/images/4556.jpg",
					Type = "Wooden",
					Price = 1300.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "eef7fb7b-a155-419a-a7f7-6b6fc865ae03"
				},
				new Door
				{
					DoorId = Guid.Parse("63ab936a-7fa3-4578-99f6-dcd8608baad1"),
					Model = "W-236-Боряна",
					ImageUrl = "https://www.idialvrati.com/cache/images/4561.jpg",
					Type = "Wooden",
					Price = 1250.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},
				new Door
				{
					DoorId = Guid.Parse("ef13a19f-4149-4b92-92f9-bbd3d2ce5e53"),
					Model = "W-235-Алина",
					ImageUrl = "https://www.idialvrati.com/cache/images/4563.jpg",
					Type = "Wooden",
					Price = 1280.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},

				new Door
				{
					DoorId = Guid.Parse("988fbb66-32b9-4dd0-8458-e0202b5c4816"),
					Model = "S-131",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/03/%D0%9B%D0%90%D0%9C%D0%98%D0%9D%D0%90%D0%A2_%D0%9E%D0%A0%D0%95%D0%A5-%D0%9A%D0%9E%D0%A0%D0%A1%D0%98%D0%9A%D0%90.png",
					Type = "Smooth",
					Price = 635.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},

				new Door
				{
					DoorId = Guid.Parse("5fd5662d-99b7-4bee-b0dd-1c4f6837e387"),
					Model = "S-132",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2018/04/tech-dab-01-300-670.jpg",
					Type = "Smooth",
					Price = 835.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},

				new Door
				{
					DoorId = Guid.Parse("ec7dce3e-9fb9-4857-9148-4ea9b776ba24"),
					Model = "S-133",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/03/INTARZIA-1.png",
					Type = "Smooth",
					Price = 915.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "b12cdb67-7ae7-4ae7-a7d0-22815749c41f"
				},
				new Door
				{
					DoorId = Guid.Parse("8b59a026-9c22-4e66-a5e5-f2eb2fe22663"),
					Model = "S-134",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/03/0007color.jpg",
					Type = "Smooth",
					Price = 805.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "b12cdb67-7ae7-4ae7-a7d0-22815749c41f"
				},

				new Door
				{
					DoorId = Guid.Parse("8e8904a5-de04-4f1e-a78b-6d24bd7ea78a"),
					Model = "S-135",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/0000prestige.jpg",
					Type = "Smooth",
					Price = 1280.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "b12cdb67-7ae7-4ae7-a7d0-22815749c41f"
				},

				new Door
				{
					DoorId = Guid.Parse("70552a44-2166-4aa2-a114-a40f7b31bdb9"),
					Model = "P-651",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%A7%D0%95%D0%A0%D0%95%D0%A8%D0%90-%D0%A0%D0%98%D0%9C.png",
					Type = "Profiled",
					Price = 915.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},

				new Door
				{
					DoorId = Guid.Parse("3ba1296e-029f-42c0-8f43-414a6a3650bc"),
					Model = "P-652",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/0008europe.jpg",
					Type = "Profiled",
					Price = 915.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},

				new Door
				{
					DoorId = Guid.Parse("c8f0a9bc-920c-4435-bf39-e2f462640b4b"),
					Model = "P-653",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%92%D0%95%D0%9D%D0%95%D0%A6%D0%98%D0%AF-300-670.png",
					Type = "Profiled",
					Price = 975.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "eef7fb7b-a155-419a-a7f7-6b6fc865ae03"
				},

				new Door
				{
					DoorId = Guid.Parse("1d6842c1-474f-4688-bdff-dc3abb83a3d2"),
					Model = "P-654",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%96%D0%95%D0%9D%D0%95%D0%92%D0%90-%D0%AF%D0%A1%D0%95%D0%9D-1013-300-680.png",
					Type = "Profiled",
					Price = 915.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "eef7fb7b-a155-419a-a7f7-6b6fc865ae03"
				},

				new Door
				{
					DoorId = Guid.Parse("2bc078ce-7786-4362-b936-1a0c21140201"),
					Model = "P-655",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/LONDON-48-SINEMORETC-300-670.png",
					Type = "Profiled",
					Price = 930.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "eef7fb7b-a155-419a-a7f7-6b6fc865ae03"
				},

				new Door
				{
					DoorId = Guid.Parse("c829575d-b139-4137-a8c9-4e1d22d35a53"),
					Model = "G-951",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/0002tetris.jpg",
					Type = "Glazed",
					Price = 1300.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f"
				},

				new Door
				{
					DoorId = Guid.Parse("fb98b190-80d7-42fd-a0a4-d1421ea03970"),
					Model = "G-952",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%AF%D0%A1%D0%95%D0%9D-1013-storgozia14.png",
					Type = "Glazed",
					Price = 1200.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "bee1ccb1-7179-4d28-a154-2dbb5f88c189"
				},

				new Door
				{
					DoorId = Guid.Parse("d8738414-dbbe-465f-945b-492214473c3d"),
					Model = "G-953",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%A1%D0%98%D0%9B%D0%A3%D0%95%D0%A2-%D0%9E%D0%A0%D0%95%D0%A5-%D0%9B%D0%90%D0%93%D0%A3%D0%9D%D0%901.png",
					Type = "Glazed",
					Price = 1080.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "bee1ccb1-7179-4d28-a154-2dbb5f88c189"
				},

				new Door
				{
					DoorId = Guid.Parse("7099f6ff-e9a5-4204-bc0a-5abadc7e57d0"),
					Model = "G-954",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%9C%D0%9B%D0%90%D0%94%D0%9E%D0%A1%D0%A2-05%D0%90.png",
					Type = "Glazed",
					Price = 1180.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "bee1ccb1-7179-4d28-a154-2dbb5f88c189"
				},

				new Door
				{
					DoorId = Guid.Parse("20c499b1-ed63-4576-acba-1b9c61a66e2b"),
					Model = "G-955",
					ImageUrl = "https://karabulev.eu/wp-content/uploads/2017/04/%D0%9B%D0%95%D0%99%D0%94%D0%98-%D0%93%D0%9B%D0%90%D0%A1-300%D1%85600.png",
					Type = "Glazed",
					Price = 1215.00m,
					Height = 200m,
					Width = 90m,
					Thickness = 35m,
					ApplicationUserId = "bee1ccb1-7179-4d28-a154-2dbb5f88c189"
				},

			};

			return list;
		}

	}
}



