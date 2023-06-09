﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web_api_products.DataBase;

#nullable disable

namespace web_api_products.Migrations
{
    [DbContext(typeof(ShopDB))]
    [Migration("20230405190624_FixingBugs")]
    partial class FixingBugs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProducer", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProducersId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductsProducersId");

                    b.HasIndex("ProductsProducersId");

                    b.ToTable("CategoryProducers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("web_api_products.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Headphones"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptops"
                        });
                });

            modelBuilder.Entity("web_api_products.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ColorHex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("web_api_products.Models.FilterName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("FilterNames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "HeadphoneType"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "GraphicCard"
                        });
                });

            modelBuilder.Entity("web_api_products.Models.FilterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FilterNameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FilterNameId");

                    b.ToTable("FilterValues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FilterNameId = 1,
                            IsActive = false,
                            Value = "TWS"
                        },
                        new
                        {
                            Id = 2,
                            FilterNameId = 1,
                            IsActive = false,
                            Value = "Wired"
                        },
                        new
                        {
                            Id = 3,
                            FilterNameId = 1,
                            IsActive = false,
                            Value = "Wireless"
                        },
                        new
                        {
                            Id = 4,
                            FilterNameId = 2,
                            IsActive = false,
                            Value = "RTX 3060"
                        },
                        new
                        {
                            Id = 5,
                            FilterNameId = 2,
                            IsActive = false,
                            Value = "RTX 3070"
                        });
                });

            modelBuilder.Entity("web_api_products.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId")
                        .IsUnique()
                        .HasFilter("[CategoryId] IS NOT NULL");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1_1.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "1_2.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "1_3.jpg",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "2_1.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "2_2.jpg",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "3_1.jpg",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "4_1.jpg",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "5_1.jpg",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 9,
                            Name = "6_1.jpg",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 10,
                            Name = "7_1.jpg",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 11,
                            Name = "8_1.jpg",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Name = "headphone_category.jpg"
                        },
                        new
                        {
                            Id = 13,
                            Name = "9_1.jpg",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 14,
                            Name = "9_2.jpg",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 15,
                            Name = "10_1.jpg",
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("web_api_products.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sony"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bose"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sennheiser"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Audio-Technica"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Asus"
                        });
                });

            modelBuilder.Entity("web_api_products.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Products", (string)null);

                    b.HasDiscriminator<string>("ProductType").HasValue("Product");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("web_api_products.Models.ProductStorage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductStorage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 220,
                            IsAvailable = true,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Count = 2,
                            IsAvailable = true,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Count = 202,
                            IsAvailable = true,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            Count = 100,
                            IsAvailable = true,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            Count = 20,
                            IsAvailable = false,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            Count = 5,
                            IsAvailable = true,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            Count = 20,
                            IsAvailable = true,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            Count = 40,
                            IsAvailable = true,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            Count = 10,
                            IsAvailable = true,
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            Count = 0,
                            IsAvailable = false,
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("web_api_products.Models.ShopUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("web_api_products.Models.Gadgets.Headphone", b =>
                {
                    b.HasBaseType("web_api_products.Models.Product");

                    b.Property<int>("HeadphoneType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Headphone");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Noise cancelling headphones",
                            Name = "Bose QuietComfort 35 II",
                            Price = 349.99000000000001,
                            ProducerId = 1,
                            HeadphoneType = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Noise cancelling headphones",
                            Name = "Sony WH-1000XM4",
                            Price = 349.99000000000001,
                            ProducerId = 2,
                            HeadphoneType = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Wireless earbuds with noise cancelling",
                            Name = "Apple AirPods Pro",
                            Price = 249.99000000000001,
                            ProducerId = 3,
                            HeadphoneType = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Wireless earbuds with noise cancelling",
                            Name = "Samsung Galaxy Buds Pro",
                            Price = 199.99000000000001,
                            ProducerId = 4,
                            HeadphoneType = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Smart soundbar for TV",
                            Name = "Sonos Beam",
                            Price = 399.99000000000001,
                            ProducerId = 1,
                            HeadphoneType = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Smart soundbar for TV",
                            Name = "Bose Soundbar 700",
                            Price = 799.99000000000001,
                            ProducerId = 2,
                            HeadphoneType = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Dolby Atmos soundbar for TV",
                            Name = "Vizio Elevate",
                            Price = 999.99000000000001,
                            ProducerId = 3,
                            HeadphoneType = 2
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "Dolby Atmos soundbar for TV",
                            Name = "LG SK10Y",
                            Price = 749.89999999999998,
                            ProducerId = 4,
                            HeadphoneType = 0
                        });
                });

            modelBuilder.Entity("web_api_products.Models.Gadgets.Laptop", b =>
                {
                    b.HasBaseType("web_api_products.Models.Product");

                    b.Property<string>("GraphicCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Laptop");

                    b.HasData(
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "The MacBook Air is a thin and light laptop with a Retina display and Touch ID.",
                            Name = "MacBook Air",
                            Price = 999.99000000000001,
                            ProducerId = 5,
                            GraphicCard = "Intel Iris Plus Graphics"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "The Asus ZenBook UX425 is a sleek and powerful laptop with an OLED display.",
                            Name = "Asus ZenBook UX425",
                            Price = 1199.99,
                            ProducerId = 6,
                            GraphicCard = "Intel Iris Xe Graphics"
                        });
                });

            modelBuilder.Entity("CategoryProducer", b =>
                {
                    b.HasOne("web_api_products.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_api_products.Models.Producer", null)
                        .WithMany()
                        .HasForeignKey("ProductsProducersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("web_api_products.Models.ShopUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("web_api_products.Models.ShopUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_api_products.Models.ShopUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("web_api_products.Models.ShopUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("web_api_products.Models.Color", b =>
                {
                    b.HasOne("web_api_products.Models.Product", "Product")
                        .WithMany("Colors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("web_api_products.Models.FilterName", b =>
                {
                    b.HasOne("web_api_products.Models.Category", "Category")
                        .WithMany("Filters")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("web_api_products.Models.FilterValue", b =>
                {
                    b.HasOne("web_api_products.Models.FilterName", "FilterName")
                        .WithMany("Values")
                        .HasForeignKey("FilterNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterName");
                });

            modelBuilder.Entity("web_api_products.Models.Image", b =>
                {
                    b.HasOne("web_api_products.Models.Category", "Category")
                        .WithOne("Image")
                        .HasForeignKey("web_api_products.Models.Image", "CategoryId");

                    b.HasOne("web_api_products.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("web_api_products.Models.Product", b =>
                {
                    b.HasOne("web_api_products.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("web_api_products.Models.Producer", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("web_api_products.Models.ProductStorage", b =>
                {
                    b.HasOne("web_api_products.Models.Product", "Product")
                        .WithOne("ProductStorage")
                        .HasForeignKey("web_api_products.Models.ProductStorage", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("web_api_products.Models.Category", b =>
                {
                    b.Navigation("Filters");

                    b.Navigation("Image")
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("web_api_products.Models.FilterName", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("web_api_products.Models.Producer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("web_api_products.Models.Product", b =>
                {
                    b.Navigation("Colors");

                    b.Navigation("ProductImages");

                    b.Navigation("ProductStorage")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
