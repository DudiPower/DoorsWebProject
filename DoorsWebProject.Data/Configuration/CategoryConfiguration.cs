namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using System;
	using System.Collections.Generic;
	using static DoorsWebProject.Data.Common.EntityConstants.Category;

	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder
				.HasKey(c => c.CategoryId);

			builder
				.Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(CategoryNameMaxLength);


			builder
				.Property(c => c.IsDeleted)
				.IsRequired()
				.HasDefaultValue(false);



			builder
				.HasData(this.SeedCategories());
		}

		public List<Category> SeedCategories()
		{
			List<Category> allCategoriesForSeed = new List<Category>()
			{
				new Category
			{
				CategoryId = Guid.Parse("9ff68438-ff2c-4ac5-946c-6bdce11e0d38"),
				Name = "Гладки врати"
			},
			new Category
			{
				CategoryId = Guid.Parse("618ada51-5300-4649-97c3-e0f92dffe2c6"),
				Name = "Профилирани врати"
			},
			new Category
			{
				CategoryId = Guid.Parse("0441044a-5d32-4669-a64c-89d3d8f53cc7"),
				Name = "Остъклени врати"
			},
			new Category
			{
				CategoryId = Guid.Parse("76c39eeb-cabe-4f48-b4ca-1372de32333e"),
				Name = "Блиндирани врати"
			},
			new Category
			{
				CategoryId = Guid.Parse("3a5e16ff-5c63-48c9-9480-5d139fc359ac"),
				Name = "Дървени врати"
			},
			new Category
			{
				CategoryId = Guid.Parse("45e6bc98-863c-4bb6-9741-549e9c2971a0"),
				Name = "Плътни врати"
			},
			};

			return allCategoriesForSeed;
		}
	}
}
