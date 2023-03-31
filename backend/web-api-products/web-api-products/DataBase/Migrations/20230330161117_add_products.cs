using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_api_products.Migrations
{
    /// <inheritdoc />
    public partial class add_products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilterValues_FilterNames_FilterNameId",
                table: "FilterValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilterValues",
                table: "FilterValues");

            migrationBuilder.RenameTable(
                name: "FilterValues",
                newName: "FilterValue");

            migrationBuilder.RenameColumn(
                name: "ContractType",
                table: "Products",
                newName: "ProductType");

            migrationBuilder.RenameIndex(
                name: "IX_FilterValues_FilterNameId",
                table: "FilterValue",
                newName: "IX_FilterValue_FilterNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilterValue",
                table: "FilterValue",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilterValue_FilterNames_FilterNameId",
                table: "FilterValue",
                column: "FilterNameId",
                principalTable: "FilterNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilterValue_FilterNames_FilterNameId",
                table: "FilterValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilterValue",
                table: "FilterValue");

            migrationBuilder.RenameTable(
                name: "FilterValue",
                newName: "FilterValues");

            migrationBuilder.RenameColumn(
                name: "ProductType",
                table: "Products",
                newName: "ContractType");

            migrationBuilder.RenameIndex(
                name: "IX_FilterValue_FilterNameId",
                table: "FilterValues",
                newName: "IX_FilterValues_FilterNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilterValues",
                table: "FilterValues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilterValues_FilterNames_FilterNameId",
                table: "FilterValues",
                column: "FilterNameId",
                principalTable: "FilterNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
