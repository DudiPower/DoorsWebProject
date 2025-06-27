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

	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder
				.HasData(this.SeedCategories());
		}

		public List<Category> SeedCategories()
		{
			List<Category> allCategoriesForSeed = new List<Category>()
			{
				new Category
			{
				Id = Guid.Parse("a3b9d5e1-8e5f-4f7b-9c88-bc6fbc761211"),
				Name = "Security Doors"
			},
			new Category
			{
				Id = Guid.Parse("b6e2f5c7-33dc-4c0e-920f-1a3fa7c6e9d2"),
				Name = "Interior Doors"
			},
			new Category
			{
				Id = Guid.Parse("c9f0a6d5-2344-45c2-bbe2-50d207b8573d"),
				Name = "Exterior Doors"
			},
			new Category
			{
				Id = Guid.Parse("d1a8e6c9-baf4-4e47-93d2-1cc9bcd69fe0"),
				Name = "Fireproof Doors"
			},
			new Category
			{
				Id = Guid.Parse("e3f7c1a4-39c3-43d3-8369-c1d267bb4371"),
				Name = "Sliding Doors"
			}
			};

			return allCategoriesForSeed;
		}
	}
}
