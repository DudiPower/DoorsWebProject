namespace DoorsWebProject.Data.Configuration
{
	using DoorsWebProject.Data.Models;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	using static DoorsWebProject.Data.Common.EntityConstants.Color;
	using System;

	public class ColorConfiguration : IEntityTypeConfiguration<Color>
	{
		public void Configure(EntityTypeBuilder<Color> builder)
		{
			builder
				.HasKey(c => c.ColorId);

			builder
				.Property(c => c.NameColor)
				.IsRequired()
				.HasMaxLength(255);

			builder
				.Property(c => c.HexCode)
				.IsRequired()
				.HasMaxLength(ColorNameMaxLength);

			builder
				.Property(c => c.IsDeleted)
				.IsRequired()
				.HasDefaultValue(false);

		}
	}
}
