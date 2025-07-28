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


		}
	}
}
