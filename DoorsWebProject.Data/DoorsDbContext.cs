namespace DoorsWebProject.Data
{
	using DoorsWebProject.Data.Models;
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
	using System.Reflection;

	public class DoorsDbContext : IdentityDbContext
    {
        public DoorsDbContext(DbContextOptions<DoorsDbContext> options)
            : base(options)
        {

        }

		public DbSet<Basket> Baskets { get; set; } = null!;

		public DbSet<Category> Categories { get; set; } = null!;

		public DbSet<Color> Colors { get; set; } = null!;

		public DbSet<Door> Doors { get; set; } = null!;

		public DbSet<Wishlist> Wishlists { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
