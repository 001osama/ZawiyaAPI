﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZawiyaAPI.Data;

#nullable disable

namespace ZawiyaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ZawiyaAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("ZawiyaAPI.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BidId"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BidTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCurrentBid")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BidId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Bids");

                    b.HasData(
                        new
                        {
                            BidId = 1,
                            Amount = 20,
                            BidTime = new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2824),
                            BuyerId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2825),
                            IsCurrentBid = true,
                            ProductId = 1,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2826)
                        },
                        new
                        {
                            BidId = 2,
                            Amount = 80,
                            BidTime = new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2832),
                            BuyerId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2833),
                            IsCurrentBid = true,
                            ProductId = 2,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2834)
                        },
                        new
                        {
                            BidId = 3,
                            Amount = 100,
                            BidTime = new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2835),
                            BuyerId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2836),
                            IsCurrentBid = true,
                            ProductId = 2,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2837)
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuyerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BuyerId");

                    b.HasIndex("UserId");

                    b.ToTable("Buyers");

                    b.HasData(
                        new
                        {
                            BuyerId = 1,
                            Address = "987 Pine Street",
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2741),
                            PhoneNumber = "555-3456",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2743),
                            UserId = "7a0c78c3-5ae4-4a6c-bb53-acc06c3d3889"
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartsId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2885),
                            Description = "The art of decorating fabric or other materials using a needle and thread, often showcasing intricate patterns and designs. A prominent craft in Pakistan, known for its vibrant and detailed work.",
                            Name = "Embroidery",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2886)
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2888),
                            Description = "The skill of carving, shaping, or creating objects from wood. Woodwork in Pakistan displays a rich heritage of craftsmanship, incorporating traditional motifs and techniques into furniture, decorative items, and architectural elements.",
                            Name = "Woodwork",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2889)
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2890),
                            Description = "The art of making objects, such as pottery, from clay and firing them in a kiln. Pakistani ceramics encompass a wide range of styles, from traditional terracotta pottery to intricate hand-painted tiles and delicate porcelain.",
                            Name = "Ceramics",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2891)
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2892),
                            Description = "The artistic writing of languages, often using special pens or brushes. Calligraphy holds a special place in Pakistani art and culture, with beautiful Arabic and Urdu calligraphy being featured in religious texts, architecture, and various forms of artistic expression.",
                            Name = "Calligraphy",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2893)
                        },
                        new
                        {
                            CategoryId = 5,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2894),
                            Description = "The craft of adorning fabrics with small mirror pieces, creating intricate patterns and reflecting light. Mirror work, also known as shisha embroidery, is widely practiced in Pakistan, particularly in regions like Sindh and Gujarat, and is used in clothing, accessories, and home decor.",
                            Name = "Mirror Work",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2895)
                        },
                        new
                        {
                            CategoryId = 6,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2896),
                            Description = "The art of shaping and manipulating metals, often involving techniques such as casting, engraving, and filigree. Pakistani metalwork showcases the country's rich heritage, with skilled artisans creating intricate jewelry, decorative items, and utensils using metals like gold, silver, and brass.",
                            Name = "Metal Work",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2896)
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentIntentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("BuyerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            BuyerId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2798),
                            OrderDate = new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2792),
                            Status = "Completed",
                            TotalAmount = 20,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2799)
                        },
                        new
                        {
                            OrderId = 2,
                            BuyerId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2802),
                            OrderDate = new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2801),
                            Status = "Completed",
                            TotalAmount = 80,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2803)
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderDetailId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2767),
                            OrderId = 1,
                            ProductId = 1,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2769)
                        },
                        new
                        {
                            OrderDetailId = 2,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2771),
                            OrderId = 2,
                            ProductId = 2,
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2772)
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<DateTime>("BidEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BidStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentPrice")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("StartingPrice")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BidEndTime = new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2855),
                            BidStartTime = new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2859),
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2857),
                            CurrentPrice = 20,
                            Description = "Handmade pillow cover featuring intricate embroidery work",
                            ImageUrl = "https://images.pexels.com/photos/12814967/pexels-photo-12814967.jpeg",
                            Name = "Embroidered Pillow Cover",
                            SellerId = 1,
                            StartingPrice = 16,
                            Status = "Active",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2858)
                        },
                        new
                        {
                            ProductId = 2,
                            BidEndTime = new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2862),
                            BidStartTime = new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2865),
                            CategoryId = 4,
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2863),
                            CurrentPrice = 80,
                            Description = "Elegant calligraphy art piece showcasing intricate Arabic script",
                            ImageUrl = "https://images.pexels.com/photos/15287945/pexels-photo-15287945.jpeg",
                            Name = "Calligraphy Art Piece",
                            SellerId = 1,
                            StartingPrice = 70,
                            Status = "Active",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2864)
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SellerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SellerId");

                    b.HasIndex("UserId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            SellerId = 1,
                            Address = "789 Oak Street",
                            CreatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2548),
                            PhoneNumber = "555-9012",
                            UpdatedDate = new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2560),
                            UserId = "45c3802c-8f4d-4a2d-a9f6-2090b70bd12b"
                        });
                });

            modelBuilder.Entity("ZawiyaAPI.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Bid", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.Buyer", "Buyer")
                        .WithMany("Bids")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZawiyaAPI.Models.Product", "Products")
                        .WithMany("Bids")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Buyer", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.CartItem", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZawiyaAPI.Models.ShoppingCart", "ShoppingCarts")
                        .WithMany("CartItems")
                        .HasForeignKey("ShoppingCartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Order", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.Buyer", "Buyer")
                        .WithMany("Orders")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.OrderDetail", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZawiyaAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Product", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZawiyaAPI.Models.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Seller", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.ShoppingCart", b =>
                {
                    b.HasOne("ZawiyaAPI.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Buyer", b =>
                {
                    b.Navigation("Bids");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Product", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.Seller", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ZawiyaAPI.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
