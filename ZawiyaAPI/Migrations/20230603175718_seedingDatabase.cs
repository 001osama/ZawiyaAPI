using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZawiyaAPI.Migrations
{
    public partial class seedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "Address", "CreatedDate", "PhoneNumber", "UpdatedDate", "UserId" },
                values: new object[] { 1, "987 Pine Street", new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(6997), "555-3456", new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7001), "7a0c78c3-5ae4-4a6c-bb53-acc06c3d3889" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7155), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7158), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7161), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7162), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7164), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7166), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "Address", "CreatedDate", "PhoneNumber", "UpdatedDate", "UserId" },
                values: new object[] { 1, "789 Oak Street", new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(6675), "555-9012", new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(6688), "45c3802c-8f4d-4a2d-a9f6-2090b70bd12b" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "BuyerId", "CreatedDate", "OrderDate", "Status", "TotalAmount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7067), "Completed", 20, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7075) },
                    { 2, 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7077), "Completed", 80, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7080) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BidEndTime", "BidStartTime", "CategoryId", "CreatedDate", "CurrentPrice", "Description", "ImageUrl", "Name", "SellerId", "StartingPrice", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7130), new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7133), 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7132), 20, "Handmade pillow cover featuring intricate embroidery work", "https://images.pexels.com/photos/12814967/pexels-photo-12814967.jpeg", "Embroidered Pillow Cover", 1, 16, "Active", new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7132) },
                    { 2, new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7136), new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7139), 4, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7138), 80, "Elegant calligraphy art piece showcasing intricate Arabic script", "https://images.pexels.com/photos/15287945/pexels-photo-15287945.jpeg", "Calligraphy Art Piece", 1, 70, "Active", new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7138) }
                });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "BidId", "Amount", "BidTime", "BuyerId", "CreatedDate", "IsCurrentBid", "ProductId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7098), 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7099), true, 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7100) },
                    { 2, 80, new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7102), 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7103), true, 2, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7104) }
                });

            migrationBuilder.InsertData(
                table: "Orderdetail",
                columns: new[] { "OrderDetailId", "CreatedDate", "OrderId", "ProductId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7042), 1, 1, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7043) },
                    { 2, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7045), 2, 2, new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7045) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orderdetail",
                keyColumn: "OrderDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orderdetail",
                keyColumn: "OrderDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7271), new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7297), new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7306), new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7311), new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7313), new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7314) });
        }
    }
}
