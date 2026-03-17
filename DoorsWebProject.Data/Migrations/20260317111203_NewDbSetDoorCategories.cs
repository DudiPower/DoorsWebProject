using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewDbSetDoorCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoorCategory_Categories_CategoryId",
                table: "DoorCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorCategory_Doors_DoorId",
                table: "DoorCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoorCategory",
                table: "DoorCategory");

            migrationBuilder.RenameTable(
                name: "DoorCategory",
                newName: "DoorCategories");

            migrationBuilder.RenameIndex(
                name: "IX_DoorCategory_CategoryId",
                table: "DoorCategories",
                newName: "IX_DoorCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoorCategories",
                table: "DoorCategories",
                columns: new[] { "DoorId", "CategoryId" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("0441044a-5d32-4669-a64c-89d3d8f53cc7"), "Остъклени врати" },
                    { new Guid("3a5e16ff-5c63-48c9-9480-5d139fc359ac"), "Дървени врати" },
                    { new Guid("45e6bc98-863c-4bb6-9741-549e9c2971a0"), "Плътни врати" },
                    { new Guid("618ada51-5300-4649-97c3-e0f92dffe2c6"), "Профилирани врати" },
                    { new Guid("76c39eeb-cabe-4f48-b4ca-1372de32333e"), "Блиндирани врати" },
                    { new Guid("9ff68438-ff2c-4ac5-946c-6bdce11e0d38"), "Гладки врати" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCategories_Categories_CategoryId",
                table: "DoorCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCategories_Doors_DoorId",
                table: "DoorCategories",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoorCategories_Categories_CategoryId",
                table: "DoorCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorCategories_Doors_DoorId",
                table: "DoorCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoorCategories",
                table: "DoorCategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("0441044a-5d32-4669-a64c-89d3d8f53cc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("3a5e16ff-5c63-48c9-9480-5d139fc359ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("45e6bc98-863c-4bb6-9741-549e9c2971a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("618ada51-5300-4649-97c3-e0f92dffe2c6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("76c39eeb-cabe-4f48-b4ca-1372de32333e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("9ff68438-ff2c-4ac5-946c-6bdce11e0d38"));

            migrationBuilder.RenameTable(
                name: "DoorCategories",
                newName: "DoorCategory");

            migrationBuilder.RenameIndex(
                name: "IX_DoorCategories_CategoryId",
                table: "DoorCategory",
                newName: "IX_DoorCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoorCategory",
                table: "DoorCategory",
                columns: new[] { "DoorId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCategory_Categories_CategoryId",
                table: "DoorCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCategory_Doors_DoorId",
                table: "DoorCategory",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId");
        }
    }
}
