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

	public class BasketConfiguration : IEntityTypeConfiguration<Basket>
	{
		public void Configure(EntityTypeBuilder<Basket> builder)
		{
			builder
				.HasKey(b => b.BasketId);

			builder
				.Property(b => b.IsDeleted)
				.IsRequired()
				.HasDefaultValue(false);

			builder
				.HasOne(b => b.User)
				.WithMany()
				.HasForeignKey(b => b.ApplicationUserId);


			//builder
			//.HasData(this.SeedBaskets());
		}

		//public List<Basket> SeedBaskets()
		//{
		//	List<Basket> listBaskets = new List<Basket>()
		//	{
		//		 new Basket
		//	{
		//		BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000001")
		//	},
		//	new Basket
		//	{
		//		BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000002")
		//	},
		//	new Basket
		//	{
		//		BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000003")
		//	},
		//	new Basket
		//	{
		//		BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000004")
		//	},
		//	new Basket
		//	{
		//		BasketId = Guid.Parse("11111111-aaaa-4bbb-8ccc-000000000005")
		//	}
		//	};

		//	return listBaskets;
		//}
	}
}
