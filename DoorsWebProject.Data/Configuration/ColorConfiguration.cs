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

			builder
				.HasData(SeedColors());

		}

		public List<Color> SeedColors() 
		{
			List<Color> dataColors = new List<Color>()
			{
				new Color
				{
					ColorId = Guid.Parse("2b90c521-fe5c-4d18-b529-eb9f2b545efb"),
					NameColor = "Дъб",
					HexCode = "#D8B589",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},
				new Color
				{
					ColorId = Guid.Parse("0f65c147-aa61-495e-a597-963b6ee6a36c"),
					NameColor = "Орех",
					HexCode = "#42291A",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},
				new Color
				{
					ColorId = Guid.Parse("d9f1e7c2-69ea-442c-8284-42f6343f0898"),
					NameColor = "Венге",
					HexCode = "#645452",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("649f1a32-4928-48b2-947d-599df8748d6f"),
					NameColor = "Явор",
					HexCode = "#F1C38E",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("65a39814-a1cc-4a57-96e2-4afc22fd4d2a"),
					NameColor = "Ясен",
					HexCode = "#A48071",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("f5483f5f-9fc3-4651-8c2b-637eebabfa8f"),
					NameColor = "Бяло",
					HexCode = "#FFFFFF",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},
				new Color
				{
					ColorId = Guid.Parse("4c462fcc-14b2-4af1-8c54-dbb6db5b15dc"),
					NameColor = "Златен дъб",
					HexCode = "#B5833D",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("e19eaf04-246f-4669-9a3e-a5158ba86306"),
					NameColor = "Сив дъб",
					HexCode = "#504c4b",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("43f687c1-3b7b-4611-833f-e11cf5c5e1f2"),
					NameColor = "Череша",
					HexCode = "#7B2716",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("48df69c8-8082-41a4-9a49-f76e66e3f1bc"),
					NameColor = "Махагон",
					HexCode = "#C04000",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("e099139e-4a0a-4c2b-a62e-45b5299f4ea9"),
					NameColor = "Черно",
					HexCode = "#1a1818",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("be968e0c-5802-4898-a60f-097fa2df63b5"),
					NameColor = "Зелено",
					HexCode = "#2E6F40",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},

				new Color
				{
					ColorId = Guid.Parse("623c8827-062e-43a9-bc87-763c47363aba"),
					NameColor = "Синьо",
					HexCode = "#016388",
					TextureUrl = "/textures/wooden-textured-background.jpg"

				},
			};

			return dataColors;
		}
	}
}
