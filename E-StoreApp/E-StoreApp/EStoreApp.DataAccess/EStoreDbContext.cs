using EStoreApp.Domain.Enums;
using EStoreApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreApp.DataAccess
{
    public class EStoreDbContext : DbContext
    {
        public EStoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(x => x.Products)
                .WithOne(x => x.Order)
                .HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<Product>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany(x => x.Reviews)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Reviews)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            //SEED
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "Bob",
                        LastName = "Bobsky",
                        Address = "BobskyBob 1",
                        Phone = 123123123,
                        Status = UserStatus.Admin,
                        Email = "bob@gmail.com",
                        Password = "BobBobsky"
                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "Greg",
                        LastName = "Gregsky",
                        Address = "GregskyGreg 2",
                        Phone = 321321321,
                        Status = UserStatus.Employee,
                        Email = "greg@gmail.com",
                        Password = "GregGregsky"
                    },
                    new User
                    {
                        Id = 3,
                        FirstName = "Jill",
                        LastName = "Jillsky",
                        Address = "JillJillsky 3",
                        Phone = 231123321,
                        Status = UserStatus.User,
                        Email = "Jill@gmail.com",
                        Password = "JillJillsky"
                    }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "MacBook Pro",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Laptop,
                        Image = "MacbookPro.png",
                        Price = 2500
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "iMac",
                        Description = "Some details about the product.",
                        Category = ProductCategory.PC,
                        Image = "iMac.png",
                        Price = 1200
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "iPhone 12 Pro Max",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Phone,
                        Image = "iPhone.png",
                        Price = 1200
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "AirPods Pro",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Headphones,
                        Image = "AirPods.png",
                        Price = 250
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Pro Display XDR",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Monitors,
                        Image = "DisplayXDR.png",
                        Price = 6000
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "iPhone Case",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Accessories,
                        Image = "Case.png",
                        Price = 50
                    },
                    new Product
                    {
                        Id = 7,
                        Name = "HomePod mini",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Other,
                        Image = "HomePod.png",
                        Price = 100
                    },
                    new Product
                    {
                        Id = 8,
                        Name = "Apple TV 4K",
                        Description = "Some details about the product.",
                        Category = ProductCategory.Other,
                        Image = "AppleTv.png",
                        Price = 179
                    }
                );

            modelBuilder.Entity<Order>()
                .HasData(
                    new Order
                    {
                        Id=1,
                        Delivered = false,
                        PaymentMethod = PaymentMethod.Card,
                        UserId = 1
                    },
                    new Order
                    {
                        Id = 2,
                        Delivered = true,
                        PaymentMethod = PaymentMethod.Card,
                        UserId = 2
                    },
                    new Order
                    {
                        Id = 3,
                        Delivered = true,
                        PaymentMethod = PaymentMethod.Cash,
                        UserId = 3
                    },
                    new Order
                    {
                        Id = 4,
                        Delivered = false,
                        PaymentMethod = PaymentMethod.Cash,
                        UserId = 2
                    }
                );

            modelBuilder.Entity<ProductOrder>()
                .HasData(
                    new ProductOrder
                    {
                        Id = 1,
                        OrderId = 1,
                        ProductId = 2
                    },
                    new ProductOrder
                    {
                        Id = 2,
                        OrderId = 1,
                        ProductId = 5
                    },
                    new ProductOrder
                    {
                        Id = 3,
                        OrderId = 2,
                        ProductId = 1
                    },
                    new ProductOrder
                    {
                        Id = 4,
                        OrderId = 3,
                        ProductId = 5
                    },
                    new ProductOrder
                    {
                        Id = 5,
                        OrderId = 3,
                        ProductId = 8
                    },
                    new ProductOrder
                    {
                        Id = 6,
                        OrderId = 4,
                        ProductId = 7
                    },
                    new ProductOrder
                    {
                        Id = 7,
                        OrderId = 4,
                        ProductId = 6
                    },
                    new ProductOrder
                    {
                        Id = 8,
                        OrderId = 4,
                        ProductId = 4
                    }
                );

            modelBuilder.Entity<Review>()
                .HasData(
                    new Review
                    {
                        Id = 1,
                        ProductId = 1,
                        Rate = 5,
                        ReviewText = "Some review text",
                        UserId = 2
                    },
                    new Review
                    {
                        Id = 2,
                        ProductId = 5,
                        Rate = 4,
                        ReviewText = "Some review text",
                        UserId = 1
                    }
                );
        }
    }
}
