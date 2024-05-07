﻿// <auto-generated />
using System;
using FoodServiceAPI.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodService.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("FoodService.Models.Auth.Role.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("CanAccessFinancialResources")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanAddEmployee")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanAddProduct")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanChangePrice")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanControlStock")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("FoodService.Models.Auth.User.UserBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("varchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("UserBase");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FoodService.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("longblob");

                    b.Property<bool>("IsFresh")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fresh and ripe, our tomatoes are harvested at the peak of perfection, ensuring unmatched flavor and quality.",
                            ExpirationDate = new DateTime(2024, 5, 14, 14, 31, 26, 37, DateTimeKind.Local).AddTicks(9313),
                            IsFresh = true,
                            Name = "Tomato",
                            ShortDescription = "Fresh Tomato",
                            StockQuantity = 100
                        },
                        new
                        {
                            Id = 2,
                            Description = "Our lettuces are carefully grown, offering a crisp texture and a light flavor that perfectly complements any salad.",
                            ExpirationDate = new DateTime(2024, 5, 12, 14, 31, 26, 37, DateTimeKind.Local).AddTicks(9340),
                            IsFresh = true,
                            Name = "Lettuce",
                            ShortDescription = "Crisp Lettuce",
                            StockQuantity = 50
                        },
                        new
                        {
                            Id = 3,
                            Description = "Our chicken breasts are boneless and carefully prepared to ensure tender, juicy meat, perfect for a variety of dishes.",
                            ExpirationDate = new DateTime(2024, 5, 10, 14, 31, 26, 37, DateTimeKind.Local).AddTicks(9343),
                            IsFresh = true,
                            Name = "Chicken Breast",
                            ShortDescription = "Boneless Chicken Breast",
                            StockQuantity = 30
                        },
                        new
                        {
                            Id = 4,
                            Description = "Our cheddar cheese is aged with care to develop its rich, creamy flavor, adding an irresistible touch to any dish.",
                            ExpirationDate = new DateTime(2024, 5, 17, 14, 31, 26, 37, DateTimeKind.Local).AddTicks(9345),
                            IsFresh = true,
                            Name = "Cheese",
                            ShortDescription = "Aged Cheddar Cheese",
                            StockQuantity = 40
                        },
                        new
                        {
                            Id = 5,
                            Description = "Our fresh onions are hand-selected to ensure consistent quality and flavor, adding robust, aromatic taste to any dish.",
                            ExpirationDate = new DateTime(2024, 5, 14, 14, 31, 26, 37, DateTimeKind.Local).AddTicks(9348),
                            IsFresh = true,
                            Name = "Onion",
                            ShortDescription = "Fresh Onion",
                            StockQuantity = 60
                        },
                        new
                        {
                            Id = 6,
                            Description = "Our fresh lemons are harvested at their peak of freshness, offering a citrusy, refreshing flavor that elevates any beverage or dish.",
                            ExpirationDate = new DateTime(2024, 5, 17, 14, 31, 26, 37, DateTimeKind.Local).AddTicks(9350),
                            IsFresh = true,
                            Name = "Lemon",
                            ShortDescription = "Fresh Lemon",
                            StockQuantity = 30
                        });
                });

            modelBuilder.Entity("FoodService.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FoodService.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("FoodService.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Image")
                        .HasColumnType("longblob");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Brand = "Chef's Special",
                            Description = "Our tomato soup is made with the finest fresh tomatoes, seasoned with herbs and spices for a rich, comforting flavor.",
                            Name = "Tomato Soup",
                            Price = 5.99m,
                            ShortDescription = "Delicious tomato soup",
                            Type = 3
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Brand = "Healthy Kitchen",
                            Description = "Our chicken salad is healthy and delicious, featuring tender chicken breast, crisp lettuce, and fresh vegetables, tossed in a tangy dressing.",
                            Name = "Chicken Salad",
                            Price = 8.49m,
                            ShortDescription = "Healthy chicken salad",
                            Type = 3
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Brand = "Fresh Drinks",
                            Description = "Our lemonade is made with freshly squeezed lemons, pure cane sugar, and filtered water, creating a refreshing beverage that's perfect for any occasion.",
                            Name = "Lemonade",
                            Price = 2.99m,
                            ShortDescription = "Refreshing lemonade",
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            Brand = "Burger House",
                            Description = "Our classic cheeseburger features a juicy beef patty, melted cheddar cheese, crisp lettuce, ripe tomatoes, onions, and pickles, all served on a toasted bun.",
                            Name = "Cheeseburger",
                            Price = 7.99m,
                            ShortDescription = "Classic cheeseburger",
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            Active = true,
                            Brand = "Snack Corner",
                            Description = "Our crispy onion rings are made with fresh onions, coated in a seasoned batter, and fried to golden perfection, creating a delicious side dish or snack.",
                            Name = "Onion Rings",
                            Price = 3.49m,
                            ShortDescription = "Crispy onion rings",
                            Type = 3
                        });
                });

            modelBuilder.Entity("FoodService.Models.ProductIngredient", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("ProductIngredient");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IngredientId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            IngredientId = 3
                        },
                        new
                        {
                            ProductId = 3,
                            IngredientId = 6
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            IngredientId = 4
                        },
                        new
                        {
                            ProductId = 5,
                            IngredientId = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

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

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

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
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FoodService.Models.Auth.User.ClientUser", b =>
                {
                    b.HasBaseType("FoodService.Models.Auth.User.UserBase");

                    b.HasDiscriminator().HasValue("ClientUser");
                });

            modelBuilder.Entity("FoodService.Models.Auth.User.EmployeeUser", b =>
                {
                    b.HasBaseType("FoodService.Models.Auth.User.UserBase");

                    b.HasDiscriminator().HasValue("EmployeeUser");
                });

            modelBuilder.Entity("FoodService.Models.Order", b =>
                {
                    b.HasOne("FoodService.Models.Auth.User.ClientUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodService.Models.OrderItem", b =>
                {
                    b.HasOne("FoodService.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodService.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodService.Models.ProductIngredient", b =>
                {
                    b.HasOne("FoodService.Models.Ingredient", "Ingredient")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodService.Models.Product", "Product")
                        .WithMany("ProductIngredients")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("FoodService.Models.Auth.Role.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FoodService.Models.Auth.User.UserBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FoodService.Models.Auth.User.UserBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("FoodService.Models.Auth.Role.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodService.Models.Auth.User.UserBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FoodService.Models.Auth.User.UserBase", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodService.Models.Ingredient", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("FoodService.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FoodService.Models.Product", b =>
                {
                    b.Navigation("ProductIngredients");
                });

            modelBuilder.Entity("FoodService.Models.Auth.User.ClientUser", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
