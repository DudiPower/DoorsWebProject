namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using Microsoft.IdentityModel.Tokens;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class DoorCategoryConfiguration : IEntityTypeConfiguration<DoorCategory>
	{
		public void Configure(EntityTypeBuilder<DoorCategory> builder)
		{
			builder
				.HasKey(dc => new {dc.DoorId , dc.CategoryId });

			builder
				.HasOne(dc => dc.Door)
				.WithMany(d => d.DoorCategories)
				.HasForeignKey(dc => dc.DoorId)
				.IsRequired(false);


			builder
				.HasOne(dc => dc.Category)
				.WithMany(c => c.CategoryDoors)
				.HasForeignKey(dc => dc.CategoryId);
			    
		}
	}
}
