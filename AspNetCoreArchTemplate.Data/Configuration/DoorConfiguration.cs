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

	public class DoorConfiguration : IEntityTypeConfiguration<Door>
	{
		public void Configure(EntityTypeBuilder<Door> builder)
		{

			builder
				.HasData(this.SeedDoors());
		}

		public List<Door> SeedDoors()
		{
			List<Door> list = new List<Door>()
			{
				   new Door
			{
				Id = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000001"),
				Model = "S100",
				Material = "Steel",
				Price = 499.99m,
				Size = "90x200 cm",
				CategoryId = Guid.Parse("a3b9d5e1-8e5f-4f7b-9c88-bc6fbc761211"),
				BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000001"),
				WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000001")
			},
			new Door
			{
				Id = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000002"),
				Model = "I200",
				Material = "Oak Wood",
				Price = 299.00m,
				Size = "80x200 cm",
				CategoryId = Guid.Parse("b6e2f5c7-33dc-4c0e-920f-1a3fa7c6e9d2"),
				BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000002"),
				WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000002")
			},
			new Door
			{
				Id = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000003"),
				Model = "SL300",
				Material = "Tempered Glass",
				Price = 399.50m,
				Size = "100x210 cm",
				CategoryId = Guid.Parse("e3f7c1a4-39c3-43d3-8369-c1d267bb4371"),
				BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000003"),
				WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000003")
			},
			new Door
			{
				Id = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000004"),
				Model = "F400",
				Material = "Steel with Fireproof Coating",
				Price = 749.99m,
				Size = "90x210 cm",
				CategoryId = Guid.Parse("d1a8e6c9-baf4-4e47-93d2-1cc9bcd69fe0"),
				BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000004"),
				WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000004")
			},
			new Door
			{
				Id = Guid.Parse("33333333-cccc-4ddd-aaaa-000000000005"),
				Model = "E500",
				Material = "Aluminum",
				Price = 599.00m,
				Size = "100x220 cm",
				CategoryId = Guid.Parse("c9f0a6d5-2344-45c2-bbe2-50d207b8573d"),
				BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000005"),
				WishlistId = Guid.Parse("22222222-bbbb-4ccc-9ddd-000000000005")
			}
			};

			return list;
		}
	}
}
