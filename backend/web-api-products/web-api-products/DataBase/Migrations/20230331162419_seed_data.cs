using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace web_api_products.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Category_CategoryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CategoryId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Headphones" },
                    { 2, "Laptops" }
                });

            migrationBuilder.InsertData(
                table: "Producer",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sony" },
                    { 2, "Bose" },
                    { 3, "Sennheiser" },
                    { 4, "Audio-Technica" },
                    { 5, "Apple" },
                    { 6, "Asus" }
                });

            migrationBuilder.InsertData(
                table: "FilterNames",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "HeadphoneType" },
                    { 2, 2, "GraphicCard" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "Name", "ProductId" },
                values: new object[] { 12, 1, "headphone_category.jpg", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "HeadphoneType", "IsAvailable", "Name", "Price", "ProducerId", "ProductType" },
                values: new object[,]
                {
                    { 1, 1, "Noise cancelling headphones", 0, false, "Bose QuietComfort 35 II", 349.99000000000001, 1, "Headphone" },
                    { 2, 1, "Noise cancelling headphones", 2, false, "Sony WH-1000XM4", 349.99000000000001, 2, "Headphone" },
                    { 3, 1, "Wireless earbuds with noise cancelling", 1, false, "Apple AirPods Pro", 249.99000000000001, 3, "Headphone" },
                    { 4, 1, "Wireless earbuds with noise cancelling", 2, false, "Samsung Galaxy Buds Pro", 199.99000000000001, 4, "Headphone" },
                    { 5, 1, "Smart soundbar for TV", 0, false, "Sonos Beam", 399.99000000000001, 1, "Headphone" },
                    { 6, 1, "Smart soundbar for TV", 1, false, "Bose Soundbar 700", 799.99000000000001, 2, "Headphone" },
                    { 7, 1, "Dolby Atmos soundbar for TV", 2, false, "Vizio Elevate", 999.99000000000001, 3, "Headphone" },
                    { 8, 1, "Dolby Atmos soundbar for TV", 0, false, "LG SK10Y", 749.89999999999998, 4, "Headphone" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "GraphicCard", "IsAvailable", "Name", "Price", "ProducerId", "ProductType" },
                values: new object[,]
                {
                    { 9, 2, "The MacBook Air is a thin and light laptop with a Retina display and Touch ID.", "Intel Iris Plus Graphics", false, "MacBook Air", 999.99000000000001, 5, "Laptop" },
                    { 10, 2, "The Asus ZenBook UX425 is a sleek and powerful laptop with an OLED display.", "Intel Iris Xe Graphics", false, "Asus ZenBook UX425", 1199.99, 6, "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "FilterValues",
                columns: new[] { "Id", "FilterNameId", "IsActive", "Value" },
                values: new object[,]
                {
                    { 1, 1, false, "TWS" },
                    { 2, 1, false, "Wired" },
                    { 3, 1, false, "Wireless" },
                    { 4, 2, false, "RTX 3060" },
                    { 5, 2, false, "RTX 3070" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CategoryId", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, null, "1_1.jpg", 1 },
                    { 2, null, "1_2.jpg", 1 },
                    { 3, null, "1_3.jpg", 1 },
                    { 4, null, "2_1.jpg", 2 },
                    { 5, null, "2_2.jpg", 2 },
                    { 6, null, "3_1.jpg", 3 },
                    { 7, null, "4_1.jpg", 4 },
                    { 8, null, "5_1.jpg", 5 },
                    { 9, null, "6_1.jpg", 6 },
                    { 10, null, "7_1.jpg", 7 },
                    { 11, null, "8_1.jpg", 8 },
                    { 13, null, "9_1.jpg", 9 },
                    { 14, null, "9_2.jpg", 9 },
                    { 15, null, "10_1.jpg", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId",
                unique: true,
                filter: "[CategoryId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Category_CategoryId",
                table: "Images",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Category_CategoryId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CategoryId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "FilterValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilterValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FilterValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FilterValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FilterValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FilterNames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilterNames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producer",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "Images",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<decimal>(
                name: "Size",
                table: "Images",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                column: "CategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Category_CategoryId",
                table: "Images",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
