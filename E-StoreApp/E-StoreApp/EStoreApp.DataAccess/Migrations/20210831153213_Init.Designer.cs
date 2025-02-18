﻿// <auto-generated />
using EStoreApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EStoreApp.DataAccess.Migrations
{
    [DbContext(typeof(EStoreDbContext))]
    [Migration("20210831153213_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EStoreApp.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Delivered")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Delivered = false,
                            PaymentMethod = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Delivered = true,
                            PaymentMethod = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Delivered = true,
                            PaymentMethod = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Delivered = false,
                            PaymentMethod = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 2,
                            Description = "Some details about the product.",
                            Image = "MacbookPro.png",
                            Name = "MacBook Pro",
                            Price = 2500.0
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            Description = "Some details about the product.",
                            Image = "iMac.png",
                            Name = "iMac",
                            Price = 1200.0
                        },
                        new
                        {
                            Id = 3,
                            Category = 3,
                            Description = "Some details about the product.",
                            Image = "iPhone.png",
                            Name = "iPhone 12 Pro Max",
                            Price = 1200.0
                        },
                        new
                        {
                            Id = 4,
                            Category = 4,
                            Description = "Some details about the product.",
                            Image = "AirPods.png",
                            Name = "AirPods Pro",
                            Price = 250.0
                        },
                        new
                        {
                            Id = 5,
                            Category = 5,
                            Description = "Some details about the product.",
                            Image = "DisplayXDR.png",
                            Name = "Pro Display XDR",
                            Price = 6000.0
                        },
                        new
                        {
                            Id = 6,
                            Category = 6,
                            Description = "Some details about the product.",
                            Image = "Case.png",
                            Name = "iPhone Case",
                            Price = 50.0
                        },
                        new
                        {
                            Id = 7,
                            Category = 7,
                            Description = "Some details about the product.",
                            Image = "HomePod.png",
                            Name = "HomePod mini",
                            Price = 100.0
                        },
                        new
                        {
                            Id = 8,
                            Category = 7,
                            Description = "Some details about the product.",
                            Image = "AppleTv.png",
                            Name = "Apple TV 4K",
                            Price = 179.0
                        });
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrder");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 3,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 3,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 6,
                            OrderId = 4,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 7,
                            OrderId = 4,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 8,
                            OrderId = 4,
                            ProductId = 4
                        });
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            Rate = 5,
                            ReviewText = "Some review text",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 5,
                            Rate = 4,
                            ReviewText = "Some review text",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "BobskyBob 1",
                            FirstName = "Bob",
                            LastName = "Bobsky",
                            Phone = 123123123L,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "GregskyGreg 2",
                            FirstName = "Greg",
                            LastName = "Gregsky",
                            Phone = 321321321L,
                            Status = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "JillJillsky 3",
                            FirstName = "Jill",
                            LastName = "Jillsky",
                            Phone = 231123321L,
                            Status = 3
                        });
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.Order", b =>
                {
                    b.HasOne("EStoreApp.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.ProductOrder", b =>
                {
                    b.HasOne("EStoreApp.Domain.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EStoreApp.Domain.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EStoreApp.Domain.Models.Review", b =>
                {
                    b.HasOne("EStoreApp.Domain.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EStoreApp.Domain.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
