using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZawiyaAPI.Migrations
{
    public partial class seedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedDate", "Description", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7271), "The art of decorating fabric or other materials using a needle and thread, often showcasing intricate patterns and designs. A prominent craft in Pakistan, known for its vibrant and detailed work.", "Embroidery", new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7291) },
                    { 2, new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7297), "The skill of carving, shaping, or creating objects from wood. Woodwork in Pakistan displays a rich heritage of craftsmanship, incorporating traditional motifs and techniques into furniture, decorative items, and architectural elements.", "Woodwork", new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7298) },
                    { 3, new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7300), "The art of making objects, such as pottery, from clay and firing them in a kiln. Pakistani ceramics encompass a wide range of styles, from traditional terracotta pottery to intricate hand-painted tiles and delicate porcelain.", "Ceramics", new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7301) },
                    { 4, new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7306), "The artistic writing of languages, often using special pens or brushes. Calligraphy holds a special place in Pakistani art and culture, with beautiful Arabic and Urdu calligraphy being featured in religious texts, architecture, and various forms of artistic expression.", "Calligraphy", new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7306) },
                    { 5, new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7311), "The craft of adorning fabrics with small mirror pieces, creating intricate patterns and reflecting light. Mirror work, also known as shisha embroidery, is widely practiced in Pakistan, particularly in regions like Sindh and Gujarat, and is used in clothing, accessories, and home decor.", "Mirror Work", new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7311) },
                    { 6, new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7313), "The art of shaping and manipulating metals, often involving techniques such as casting, engraving, and filigree. Pakistani metalwork showcases the country's rich heritage, with skilled artisans creating intricate jewelry, decorative items, and utensils using metals like gold, silver, and brass.", "Metal Work", new DateTime(2023, 6, 3, 16, 32, 0, 686, DateTimeKind.Local).AddTicks(7314) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);
        }
    }
}
