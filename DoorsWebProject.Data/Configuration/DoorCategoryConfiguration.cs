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

			//builder
			//	.HasData(SeedDoorCategories());

		}

		public List<DoorCategory> SeedDoorCategories()
		{
			List<DoorCategory> doorCategories = new List<DoorCategory>()
			{
				//// Armored
				new DoorCategory
				{
					DoorId = Guid.Parse("40b2ed36-b35c-4016-b998-863038968490"),
					CategoryId = Guid.Parse("76c39eeb-cabe-4f48-b4ca-1372de32333e")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("06ebf95c-7758-4ce2-afb3-191d3c57fe13"),
					CategoryId = Guid.Parse("76c39eeb-cabe-4f48-b4ca-1372de32333e")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("55e5d4dc-a4fc-4fcd-aed1-4e688e63a547"),
					CategoryId = Guid.Parse("76c39eeb-cabe-4f48-b4ca-1372de32333e")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("eddf2e0d-ed9d-431b-90d1-8af284e5289b"),
					CategoryId = Guid.Parse("76c39eeb-cabe-4f48-b4ca-1372de32333e")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("e37f55fd-1f7b-40f2-9374-e881b95c4506"),
					CategoryId = Guid.Parse("76c39eeb-cabe-4f48-b4ca-1372de32333e")
				},
				///// Wooden

				new DoorCategory
				{
					DoorId = Guid.Parse("ccc7397a-f7c6-46cd-9510-5dedb05a30f2"),
					CategoryId = Guid.Parse("3a5e16ff-5c63-48c9-9480-5d139fc359ac")
				},

				new DoorCategory
				{
					DoorId = Guid.Parse("c09bac80-7531-49b3-b147-b8e0377ad093"),
					CategoryId = Guid.Parse("3a5e16ff-5c63-48c9-9480-5d139fc359ac")
				},

				new DoorCategory
				{
					DoorId = Guid.Parse("648047b3-6e61-4932-9f22-48792f58b911"),
					CategoryId = Guid.Parse("3a5e16ff-5c63-48c9-9480-5d139fc359ac")
				},

				new DoorCategory
				{
					DoorId = Guid.Parse("63ab936a-7fa3-4578-99f6-dcd8608baad1"),
					CategoryId = Guid.Parse("3a5e16ff-5c63-48c9-9480-5d139fc359ac")
				},

				new DoorCategory
				{
					DoorId = Guid.Parse("ef13a19f-4149-4b92-92f9-bbd3d2ce5e53"),
					CategoryId = Guid.Parse("3a5e16ff-5c63-48c9-9480-5d139fc359ac")
				},

				//// Smooth
				new DoorCategory
				{
					DoorId = Guid.Parse("988fbb66-32b9-4dd0-8458-e0202b5c4816"),
					CategoryId = Guid.Parse("9ff68438-ff2c-4ac5-946c-6bdce11e0d38")
				},

				new DoorCategory
				{
					DoorId = Guid.Parse("5fd5662d-99b7-4bee-b0dd-1c4f6837e387"),
					CategoryId = Guid.Parse("9ff68438-ff2c-4ac5-946c-6bdce11e0d38")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("ec7dce3e-9fb9-4857-9148-4ea9b776ba24"),
					CategoryId = Guid.Parse("9ff68438-ff2c-4ac5-946c-6bdce11e0d38")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("8b59a026-9c22-4e66-a5e5-f2eb2fe22663"),
					CategoryId = Guid.Parse("9ff68438-ff2c-4ac5-946c-6bdce11e0d38")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("8e8904a5-de04-4f1e-a78b-6d24bd7ea78a"),
					CategoryId = Guid.Parse("9ff68438-ff2c-4ac5-946c-6bdce11e0d38")
				},

				/// Profiled
				
				new DoorCategory
				{
					DoorId = Guid.Parse("70552a44-2166-4aa2-a114-a40f7b31bdb9"),
					CategoryId = Guid.Parse("618ada51-5300-4649-97c3-e0f92dffe2c6")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("3ba1296e-029f-42c0-8f43-414a6a3650bc"),
					CategoryId = Guid.Parse("618ada51-5300-4649-97c3-e0f92dffe2c6")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("c8f0a9bc-920c-4435-bf39-e2f462640b4b"),
					CategoryId = Guid.Parse("618ada51-5300-4649-97c3-e0f92dffe2c6")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("1d6842c1-474f-4688-bdff-dc3abb83a3d2"),
					CategoryId = Guid.Parse("618ada51-5300-4649-97c3-e0f92dffe2c6")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("2bc078ce-7786-4362-b936-1a0c21140201"),
					CategoryId = Guid.Parse("618ada51-5300-4649-97c3-e0f92dffe2c6")
				},

				/// Glazed
				
				new DoorCategory
				{
					DoorId = Guid.Parse("c829575d-b139-4137-a8c9-4e1d22d35a53"),
					CategoryId = Guid.Parse("0441044a-5d32-4669-a64c-89d3d8f53cc7")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("fb98b190-80d7-42fd-a0a4-d1421ea03970"),
					CategoryId = Guid.Parse("0441044a-5d32-4669-a64c-89d3d8f53cc7")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("d8738414-dbbe-465f-945b-492214473c3d"),
					CategoryId = Guid.Parse("0441044a-5d32-4669-a64c-89d3d8f53cc7")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("7099f6ff-e9a5-4204-bc0a-5abadc7e57d0"),
					CategoryId = Guid.Parse("0441044a-5d32-4669-a64c-89d3d8f53cc7")
				},
				new DoorCategory
				{
					DoorId = Guid.Parse("20c499b1-ed63-4576-acba-1b9c61a66e2b"),
					CategoryId = Guid.Parse("0441044a-5d32-4669-a64c-89d3d8f53cc7")
				},
			};

			return doorCategories;
		}
	}
}
