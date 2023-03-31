using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_api_products.Migrations
{
    /// <inheritdoc />
    public partial class update_image : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileExtension",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Size",
                table: "Images",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileExtension",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Images");
        }
    }
}
