using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZawiyaAPI.Migrations
{
    public partial class minorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ShoppingCarts_CartId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartsId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 1,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 2,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2833), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 3,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2836), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2885), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2888), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2890), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2894), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2767), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2771), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2792), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2802), new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2855), new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 20, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2862), new DateTime(2023, 6, 19, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2865), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2863), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 6, 12, 15, 25, 31, 890, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartsId",
                table: "CartItems",
                column: "ShoppingCartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ShoppingCarts_ShoppingCartsId",
                table: "CartItems",
                column: "ShoppingCartsId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ShoppingCarts_ShoppingCartsId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ShoppingCartsId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ShoppingCartsId",
                table: "CartItems");

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 1,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5899), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5900), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 2,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5903), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5904), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 3,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 20, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5907), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "Buyers",
                keyColumn: "BuyerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5826), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6038), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6041), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6043), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6045), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6047), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6049), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "OrderDetailId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5877), new DateTime(2023, 6, 20, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5872), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "OrderDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5882), new DateTime(2023, 6, 20, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5880), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 20, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6007), new DateTime(2023, 6, 19, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6011), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6009), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "BidEndTime", "BidStartTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 20, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6014), new DateTime(2023, 6, 19, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6017), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 6, 12, 12, 53, 15, 439, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ShoppingCarts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
