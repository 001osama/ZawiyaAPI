using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZawiyaAPI.Migrations
{
    public partial class addShoppingCartToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_ShoppingCarts_CartId",
                        column: x => x.CartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 1,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 18, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6829), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6831), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 2,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 18, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6834), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6835), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.InsertData(
                table: "Bids",
                columns: new[] { "BidId", "Amount", "BidTime", "BuyerId", "CreatedDate", "IsCurrentBid", "ProductId", "UpdatedDate" },
                values: new object[] { 3, 100, new DateTime(2023, 6, 19, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6837), 1, new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6838), true, 2, new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6687), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6886), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6888), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6896), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Orderdetail",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6769), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Orderdetail",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6772), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 6, 19, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 6, 19, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6806), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6857), new DateTime(2023, 6, 18, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6862), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6860), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6865), new DateTime(2023, 6, 18, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6868), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6866), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6496), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DeleteData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 1,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7098), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7099), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 2,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7102), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7103), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(6997), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7001) });

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

            migrationBuilder.UpdateData(
                table: "Orderdetail",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Orderdetail",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7045), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7075), new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7067), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7079), new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7077), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7130), new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7132), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 11, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7136), new DateTime(2023, 6, 10, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7139), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7138), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(6675), new DateTime(2023, 6, 3, 22, 57, 18, 82, DateTimeKind.Local).AddTicks(6688) });
        }
    }
}
