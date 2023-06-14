using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Emit;
using ZawiyaAPI.Models;

namespace ZawiyaAPI.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {   
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Buyer> Buyers { get; set; } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderDetail> OrderDetails { get; set; } 
        public DbSet<Product> Products { get; set; } 
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Seller>().HasData(
               new Seller()
               {
                   SellerId = 1,
                   Address = "789 Oak Street",
                   PhoneNumber = "555-9012",
                   CreatedDate = DateTime.Now,
                   UpdatedDate = DateTime.Now,
                   UserId = "45c3802c-8f4d-4a2d-a9f6-2090b70bd12b"
               });
            modelBuilder.Entity<Buyer>().HasData(
                new Buyer()
                {
                    BuyerId = 1,
                    Address = "987 Pine Street",
                    PhoneNumber = "555-3456",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    UserId = "7a0c78c3-5ae4-4a6c-bb53-acc06c3d3889"
                });


            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail()
                {
                    OrderDetailId = 1,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OrderId = 1,
                    ProductId = 1
                },
                new OrderDetail()
                {
                    OrderDetailId = 2,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    OrderId = 2,
                    ProductId = 2
                });


            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    OrderId = 1,
                    OrderDate = DateTime.Now.AddDays(8),
                    TotalAmount = 20,
                    Status = "Completed",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = 1
                },
                new Order()
                {
                    OrderId = 2,
                    OrderDate = DateTime.Now.AddDays(8),
                    TotalAmount = 80,
                    Status = "Completed",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = 1
                });

            modelBuilder.Entity<Bid>().HasData(
                new Bid()
                {
                    BidId = 1,
                    Amount = 20,
                    BidTime = DateTime.Now.AddDays(7),
                    IsCurrentBid = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = 1,
                    ProductId = 1
                },
                new Bid()
                {
                    BidId = 2,
                    Amount = 80,
                    BidTime = DateTime.Now.AddDays(7),
                    IsCurrentBid = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = 1,
                    ProductId = 2
                },
                new Bid()
                {
                    BidId = 3,
                    Amount = 100,
                    BidTime = DateTime.Now.AddDays(8),
                    IsCurrentBid = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BuyerId = 1,
                    ProductId = 2
                });

           
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    Name = "Embroidered Pillow Cover",
                    Description = "Handmade pillow cover featuring intricate embroidery work",
                    CurrentPrice = 20,
                    BidEndTime = DateTime.Now.AddDays(8),
                    ImageUrl = "https://images.pexels.com/photos/12814967/pexels-photo-12814967.jpeg",
                    Status = "Active",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BidStartTime = DateTime.Now.AddDays(7),
                    StartingPrice = 16,
                    CategoryId = 1,
                    SellerId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    Name = "Calligraphy Art Piece",
                    Description = "Elegant calligraphy art piece showcasing intricate Arabic script",
                    CurrentPrice = 80,
                    BidEndTime = DateTime.Now.AddDays(8),
                    ImageUrl = "https://images.pexels.com/photos/15287945/pexels-photo-15287945.jpeg",
                    Status = "Active",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BidStartTime = DateTime.Now.AddDays(7),
                    StartingPrice = 70,
                    CategoryId = 4,
                    SellerId = 1
                });


            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    Name = "Embroidery",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "The art of decorating fabric or other materials using a needle and thread, often showcasing intricate patterns and designs. A prominent craft in Pakistan, known for its vibrant and detailed work."
                },
                new Category()
                {
                    CategoryId = 2,
                    Name = "Woodwork",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "The skill of carving, shaping, or creating objects from wood. Woodwork in Pakistan displays a rich heritage of craftsmanship, incorporating traditional motifs and techniques into furniture, decorative items, and architectural elements."
                },
                new Category()
                {
                    CategoryId = 3,
                    Name = "Ceramics",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "The art of making objects, such as pottery, from clay and firing them in a kiln. Pakistani ceramics encompass a wide range of styles, from traditional terracotta pottery to intricate hand-painted tiles and delicate porcelain."
                },
                new Category()
                {
                    CategoryId = 4,
                    Name = "Calligraphy",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "The artistic writing of languages, often using special pens or brushes. Calligraphy holds a special place in Pakistani art and culture, with beautiful Arabic and Urdu calligraphy being featured in religious texts, architecture, and various forms of artistic expression."
                },
                new Category()
                {
                    CategoryId = 5,
                    Name = "Mirror Work",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "The craft of adorning fabrics with small mirror pieces, creating intricate patterns and reflecting light. Mirror work, also known as shisha embroidery, is widely practiced in Pakistan, particularly in regions like Sindh and Gujarat, and is used in clothing, accessories, and home decor."
                },
                new Category()
                {
                    CategoryId = 6,
                    Name = "Metal Work",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Description = "The art of shaping and manipulating metals, often involving techniques such as casting, engraving, and filigree. Pakistani metalwork showcases the country's rich heritage, with skilled artisans creating intricate jewelry, decorative items, and utensils using metals like gold, silver, and brass."
                });
        }
    }
}
