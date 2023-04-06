using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using web_api_products.Models;
using web_api_products.Models.Gadgets;

namespace web_api_products.DataBase
{
    public class ShopDB : IdentityDbContext<ShopUser, IdentityRole<int>, int>
	{
		public ShopDB(DbContextOptions<ShopDB> options)
			 : base(options)
		{ }

		public DbSet<Headphone> Headphones { get; set; }
		public DbSet<Laptop> Laptops { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Image> Images { get; set; }
		public DbSet<FilterName> FilterNames { get; set; }
		public DbSet<FilterValue> FilterValues { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Color> Colors { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Seed();
			
			modelBuilder.Entity<Product>()
				.ToTable("Products")
				.HasOne(x=>x.Category)
				.WithMany(x=>x.Products)
				.HasForeignKey(x=>x.CategoryId);

			modelBuilder.Entity<Product>()
				.HasOne(x => x.ProductStorage)
				.WithOne(x => x.Product)
				.HasForeignKey<ProductStorage>(x => x.ProductId);

			modelBuilder.Entity<Product>()
				 .HasDiscriminator<string>("ProductType")
				 .HasValue<Headphone>("Headphone")
				 .HasValue<Laptop>("Laptop");

			modelBuilder.Entity<Product>()
				.HasOne(x=>x.Producer)
				.WithMany(x=>x.Products)
				.HasForeignKey(x=>x.ProducerId);

			modelBuilder.Entity<Product>()
				.HasMany(x => x.Colors)
				.WithOne(x=>x.Product)
				.HasForeignKey(x=>x.ProductId);

			modelBuilder.Entity<Image>()
				.HasOne(x => x.Product)
				.WithMany(x => x.ProductImages)
				.HasForeignKey(x => x.ProductId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.ClientSetNull);

			modelBuilder.Entity<Image>()
				.HasOne(x => x.Category)
				.WithOne(x => x.Image)
				.HasForeignKey<Image>(x => x.CategoryId)
				.IsRequired(false)
				;

			modelBuilder.Entity<Category>()
				.HasMany(x=>x.ProductsProducers)
				.WithMany()
				.UsingEntity(j => j.ToTable("CategoryProducers"));

			modelBuilder.Entity<Category>()
				.HasMany(x=>x.Filters)
				.WithOne(x=>x.Category)
				.HasForeignKey(x=>x.CategoryId);

			modelBuilder.Entity<FilterName>()
				.HasMany(x => x.Values)
				.WithOne(x => x.FilterName)
				.HasForeignKey(x => x.FilterNameId);


		}
	}
}
