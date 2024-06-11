﻿// <auto-generated />
using System;
using Fasterr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fasterr.Data.Migrations
{
    [DbContext(typeof(FasterrDbContext))]
    partial class FasterrDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fasterr.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("User first name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasComment("User last name");

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

            modelBuilder.Entity("Fasterr.Data.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Brand name");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nike"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adidas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Under Armour"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Puma"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Reebok"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Kipsta"
                        });
                });

            modelBuilder.Entity("Fasterr.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kits"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tracksuits"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Thermal underwear"
                        });
                });

            modelBuilder.Entity("Fasterr.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Product identifier");

                    b.Property<int?>("BrandId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasComment("Product brand");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Product category identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasComment("Product description");

                    b.Property<int?>("Discount")
                        .HasColumnType("int")
                        .HasComment("Product price discount");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Product image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasComment("Product name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product price");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasComment("Product rating");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasComment("Product type identifier");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                            BrandId = 1,
                            CategoryId = 1,
                            Description = "Стилни футболни обувки за ежедневни тренировки и мачове",
                            Discount = 0,
                            ImageURL = "https://www.futbolemotion.com/imagesarticulos/199088/grandes/bota-nike-zoom-mercurial-superfly-9-elite-fg-turquesa-0.webp",
                            Name = "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG Hyper Turq",
                            Price = 299.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                            BrandId = 1,
                            CategoryId = 1,
                            Description = "Стилни футболни обувки за ежедневни тренировки и мачове",
                            Discount = 0,
                            ImageURL = "https://thirdcoastsoccer.net/cdn/shop/products/image__80827.1657841497.1280.1280.png?v=1681567637",
                            Name = "Футболни обувки Nike Zoom Mercurial Superfly 9 Academy FG",
                            Price = 309.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                            BrandId = 1,
                            CategoryId = 1,
                            Description = "Професионални футболни обувки",
                            Discount = 0,
                            ImageURL = "https://frankfurt.apollo.olxcdn.com/v1/files/f4eqgsde7r0w1-BG/image",
                            Name = "Професионални бутонки Nike Mercurial Dream Speed Superfly 8 Elite FG",
                            Price = 409.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                            BrandId = 1,
                            CategoryId = 2,
                            Description = "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG",
                            Discount = 0,
                            ImageURL = "https://frankfurt.apollo.olxcdn.com/v1/files/cpryl7ozvivj1-BG/image;s=1800x1846",
                            Name = "DRI-FIT футболен екип PSG MBAPPE",
                            Price = 199.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                            BrandId = 4,
                            CategoryId = 2,
                            Description = "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City",
                            Discount = 0,
                            ImageURL = "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Manchester%20City/23-24/home/detski-ekip-manchester-city.jpg",
                            Name = "Puma Manchester City футболен екип 2023/2024 домакински",
                            Price = 179.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"),
                            BrandId = 1,
                            CategoryId = 2,
                            Description = "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool",
                            Discount = 0,
                            ImageURL = "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Liverpool/23%2024/Home/detski_ekip_liverpool-2023-2024.jpg",
                            Name = "Nike Liverpool футболен екип 2023/2024 домакински",
                            Price = 189.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                            BrandId = 2,
                            CategoryId = 3,
                            Description = "Долнище и горнище за тренировки 2023/2024 Аржентина",
                            Discount = 0,
                            ImageURL = "https://img4.dhresource.com/webp/m/0x0/f3/albu/km/g/30/b88fd8a7-70e7-43cb-ab4d-5fd139e12cff.jpg",
                            Name = "Анцуг за тренировка Argentina 2023/2024",
                            Price = 165.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"),
                            BrandId = 1,
                            CategoryId = 3,
                            Description = "Долнище и горнище за тренировки 2023/2024 PSG",
                            Discount = 0,
                            ImageURL = "https://m.media-amazon.com/images/I/619oiA9HqZL._AC_UY1100_.jpg",
                            Name = "Анцуг за тренировка PSG 2023/2024",
                            Price = 185.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                            BrandId = 3,
                            CategoryId = 4,
                            Description = "Удобна и качествена тениска Under Armour",
                            Discount = 0,
                            ImageURL = "https://cdn.4camping.bg/files/photos/1600/a/ad473c5b-mazhka-teniska-under-armour-hg-armour-comp-ls-cheren-black-white.jpg",
                            Name = "Термо блуза Under Armour",
                            Price = 35.99m,
                            Rating = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"),
                            BrandId = 6,
                            CategoryId = 4,
                            Description = "Удобен термо клин на KIPSTA",
                            Discount = 0,
                            ImageURL = "https://contents.mediadecathlon.com/p2480341/k$bba35f387da6b9cd9450cbcc0d46db4d/dolen-kas-klin-keepcomfort-cheren.jpg?format=auto&quality=40&f=800x800",
                            Name = "Долен къс клин KEEPCOMFORT KIPSTA",
                            Price = 25.99m,
                            Rating = 0,
                            TypeId = 1
                        });
                });

            modelBuilder.Entity("Fasterr.Data.Models.ProductBuyerCart", b =>
                {
                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Product identifier");

                    b.HasKey("BuyerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsBuyersCart");
                });

            modelBuilder.Entity("Fasterr.Data.Models.ProductBuyerPurchased", b =>
                {
                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("User identifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Product identifier");

                    b.HasKey("BuyerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsBuyersPurchased");
                });

            modelBuilder.Entity("Fasterr.Data.Models.ProductBuyerRate", b =>
                {
                    b.Property<Guid>("BuyerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BuyerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsBuyersRate");
                });

            modelBuilder.Entity("Fasterr.Data.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Man"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Women"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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

            modelBuilder.Entity("Fasterr.Data.Models.Product", b =>
                {
                    b.HasOne("Fasterr.Data.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fasterr.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fasterr.Data.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Fasterr.Data.Models.ProductBuyerCart", b =>
                {
                    b.HasOne("Fasterr.Data.Models.ApplicationUser", "Buyer")
                        .WithMany("Cart")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fasterr.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fasterr.Data.Models.ProductBuyerPurchased", b =>
                {
                    b.HasOne("Fasterr.Data.Models.ApplicationUser", "Buyer")
                        .WithMany("PurchasedProducts")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fasterr.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fasterr.Data.Models.ProductBuyerRate", b =>
                {
                    b.HasOne("Fasterr.Data.Models.ApplicationUser", "Buyer")
                        .WithMany("ProductsBuyersRate")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fasterr.Data.Models.Product", "Product")
                        .WithMany("ProductsBuyersRate")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Fasterr.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Fasterr.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fasterr.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Fasterr.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fasterr.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("ProductsBuyersRate");

                    b.Navigation("PurchasedProducts");
                });

            modelBuilder.Entity("Fasterr.Data.Models.Product", b =>
                {
                    b.Navigation("ProductsBuyersRate");
                });
#pragma warning restore 612, 618
        }
    }
}
