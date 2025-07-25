using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000001"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000002"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000003"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000004"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000005"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorId", "Description", "Height", "ImageUrl", "Material", "Model", "Price", "Thickness", "Width" },
                values: new object[,]
                {
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000001"), "High-quality steel door with modern design.", 200.0m, "https://starkdoor.com/external/public_html/images/categories/stark-premium-steel-doors.webp", "Steel", "S100", 499.99m, 4.5m, 90.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000002"), "Elegant oak wood door with smooth finish.", 200.0m, "https://mla5dc5gjk9g.i.optimole.com/cb:ykaZ.3ba35/w:auto/h:auto/q:mauto/f:best/https://www.aspire-doors.co.uk/wp-content/uploads/2023/11/oak-mexicano-prefinished-lifestyle.jpg", "Oak Wood", "I200", 299.00m, 4.0m, 80.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000003"), "Stylish tempered glass door with reinforced frame.", 210.0m, "https://supplychaingamechanger.com/wp-content/uploads/2023/08/TemperedGlass.jpg", "Tempered Glass", "SL300", 399.50m, 3.5m, 100.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000004"), "Fireproof steel door suitable for safety exits.", 210.0m, "https://5.imimg.com/data5/EM/DU/NC/SELLER-8174112/man-door-500x500.png", "Steel with Fireproof Coating", "F400", 749.99m, 5.0m, 90.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000005"), "Lightweight aluminum door with modern aesthetics.", 220.0m, "https://www.glenviewdoors.com/ExteriorAluminum/gallery/Swing-Aluminum-Exterior-Door-with-Sidelites-EAL-SWS-W6-2SL.jpg", "Aluminum", "E500", 599.00m, 3.8m, 100.0m }
                });
        }
    }
}
