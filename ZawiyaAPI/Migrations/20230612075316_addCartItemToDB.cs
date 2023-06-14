using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZawiyaAPI.Migrations
{
    public partial class addCartItemToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Products_ProductId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_ShoppingCarts_CartId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderdetail_Orders_OrderId",
                table: "Orderdetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderdetail_Products_ProductId",
                table: "Orderdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderdetail",
                table: "Orderdetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.RenameTable(
                name: "Orderdetail",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "CartItem",
                newName: "CartItems");

            migrationBuilder.RenameIndex(
                name: "IX_Orderdetail_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Orderdetail_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItems",
                newName: "IX_CartItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CartId",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ShoppingCarts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ShoppingCarts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "Orderdetail");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItem");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "Orderdetail",
                newName: "IX_Orderdetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "Orderdetail",
                newName: "IX_Orderdetail_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItem",
                newName: "IX_CartItem_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                table: "CartItem",
                newName: "IX_CartItem_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderdetail",
                table: "Orderdetail",
                column: "OrderDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Bids",
                keyColumn: "BidId",
                keyValue: 3,
                columns: new[] { "BidTime", "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 19, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6837), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 6, 11, 23, 9, 53, 16, DateTimeKind.Local).AddTicks(6839) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Products_ProductId",
                table: "CartItem",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_ShoppingCarts_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderdetail_Orders_OrderId",
                table: "Orderdetail",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderdetail_Products_ProductId",
                table: "Orderdetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
