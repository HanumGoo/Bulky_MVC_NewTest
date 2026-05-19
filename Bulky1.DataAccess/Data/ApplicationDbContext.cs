using Bulky1.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky1.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title = "Fortune of Time", Author = "Billy Spark", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec venenatis, dolor in finibus malesuada, lectus ipsum porta nunc, at iaculis arcu nisi sed mauris. Nulla fermentum vestibulum ex, eget tristique tortor pretium ut. Curabitur elit justo, consequat id condimentum ac, volutpat ornare.", ISBN = "SWD9999001", ListPrice = 99.00, Price = 90.00, Price50 = 85.00, Price100 = 80.00, CategoryId = 1 },
                new Product { Id = 2, Title = "Dark Skies", Author = "Nancy Hoover", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec venenatis, dolor in finibus malesuada, lectus ipsum porta nunc, at iaculis arcu nisi sed mauris. Nulla fermentum vestibulum ex, eget tristique tortor pretium ut. Curabitur elit justo, consequat id condimentum ac, volutpat ornare.", ISBN = "SWD9999002", ListPrice = 40.00, Price = 30.00, Price50 = 25.00, Price100 = 20.00, CategoryId = 1 },
                new Product { Id = 3, Title = "Vanish in the Sunset", Author = "Julian Button", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec venenatis, dolor in finibus malesuada, lectus ipsum porta nunc, at iaculis arcu nisi sed mauris. Nulla fermentum vestibulum ex, eget tristique tortor pretium ut. Curabitur elit justo, consequat id condimentum ac, volutpat ornare.", ISBN = "SWD9999003", ListPrice = 55.00, Price = 50.00, Price50 = 40.00, Price100 = 35.00, CategoryId = 1 },
                new Product { Id = 4, Title = "Cotton Candy", Author = "Abby Muscles", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec venenatis, dolor in finibus malesuada, lectus ipsum porta nunc, at iaculis arcu nisi sed mauris. Nulla fermentum vestibulum ex, eget tristique tortor pretium ut. Curabitur elit justo, consequat id condimentum ac, volutpat ornare.", ISBN = "SWD9999004", ListPrice = 70.00, Price = 65.00, Price50 = 60.00, Price100 = 55.00, CategoryId = 1 },
                new Product { Id = 5, Title = "Rock in the Ocean", Author = "Ron Parker", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec venenatis, dolor in finibus malesuada, lectus ipsum porta nunc, at iaculis arcu nisi sed mauris. Nulla fermentum vestibulum ex, eget tristique tortor pretium ut. Curabitur elit justo, consequat id condimentum ac, volutpat ornare.", ISBN = "SWD9999005", ListPrice = 30.00, Price = 27.00, Price50 = 25.00, Price100 = 20.00, CategoryId = 1 },
                new Product { Id = 6, Title = "Leaves and Wonders", Author = "Laura Phantom", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec venenatis, dolor in finibus malesuada, lectus ipsum porta nunc, at iaculis arcu nisi sed mauris. Nulla fermentum vestibulum ex, eget tristique tortor pretium ut. Curabitur elit justo, consequat id condimentum ac, volutpat ornare.", ISBN = "SWD9999006", ListPrice = 25.00, Price = 23.00, Price50 = 22.00, Price100 = 20.00, CategoryId = 1 }
            );
        }
    }
}
