namespace DoorsWebProject.Data
{
	using DoorsWebProject.Data.Models;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;
	using System.Reflection;

	public class DoorsDbContext : IdentityDbContext<ApplicationUser>
    {
		public DoorsDbContext()
		{
		}

		public DoorsDbContext(DbContextOptions<DoorsDbContext> options)
            : base(options)
        {

        }

		public virtual DbSet<Basket> Baskets { get; set; } = null!;

		public virtual DbSet<BasketDetail> BasketDetails { get; set; } = null!;

		public virtual DbSet<Order> Orders { get; set; } = null!;

		public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;

		public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
		public virtual DbSet<Category> Categories { get; set; } = null!;

		public virtual DbSet<DoorCategory> DoorCategories { get; set; } = null!;

		public virtual DbSet<Color> Colors { get; set; } = null!;

		public virtual DbSet<Door> Doors { get; set; } = null!;

		public virtual DbSet<ApplicationUser> Wishlists { get; set; } = null!;

		public virtual DbSet<ApplicationUserDoor> ApplicationUserDoors { get; set; } = null!;


		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
