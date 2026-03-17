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

	public class DoorColorConfiguration : IEntityTypeConfiguration<DoorColor>
	{
		public void Configure(EntityTypeBuilder<DoorColor> builder)
		{
			builder
				.HasKey(dco => new { dco.DoorId, dco.ColorId });

			builder
				.HasOne(dco => dco.Door)
				.WithMany(d => d.DoorColors)
				.HasForeignKey(dco => dco.DoorId)
				.IsRequired(false);

			builder
				.HasOne(dco => dco.Color)
				.WithMany(co => co.ColorDoors)
				.HasForeignKey(dco => dco.ColorId);

			builder
				.HasData(SeedData());
		}

		public List<DoorColor> SeedData()
		{
			List<DoorColor> doorColors = new List<DoorColor>()
			{
				new DoorColor()
				{
					DoorId = Guid.Parse("06EBF95C-7758-4CE2-AFB3-191D3C57FE13"),
					ColorId = Guid.Parse("BE968E0C-5802-4898-A60F-097FA2DF63B5")
				},
				new DoorColor()
				{
					DoorId = Guid.Parse("06EBF95C-7758-4CE2-AFB3-191D3C57FE13"),
					ColorId = Guid.Parse("D9F1E7C2-69EA-442C-8284-42F6343F0898")
				},
				new DoorColor()
				{
					DoorId = Guid.Parse("06EBF95C-7758-4CE2-AFB3-191D3C57FE13"),
					ColorId = Guid.Parse("E099139E-4A0A-4C2B-A62E-45B5299F4EA9")
				},
				new DoorColor()
				{
					DoorId = Guid.Parse("06EBF95C-7758-4CE2-AFB3-191D3C57FE13"),
					ColorId = Guid.Parse("65A39814-A1CC-4A57-96E2-4AFC22FD4D2A")
				},
			};

			return doorColors;
		}
	}
}
