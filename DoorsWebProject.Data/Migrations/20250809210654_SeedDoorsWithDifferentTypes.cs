using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoorsWithDifferentTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDoors");

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

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId");
                    table.ForeignKey(
                        name: "FK_BasketItems_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorId", "Description", "Height", "ImageUrl", "Material", "Model", "Price", "Thickness", "Type", "Width" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-4bbb-cccc-000000000002"), "Smooth steel door with minimalist style.", 210.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-steel-door.webp", "Steel", "S200", 529.99m, 4.0m, "Smooth", 95.0m },
                    { new Guid("12345678-dddd-4eee-ffff-000000000017"), "Luxury glazed aluminium door with tinted glass.", 220.0m, "https://starkdoor.com/external/public_html/images/categories/stark-glazed-lux.webp", "Aluminium + Glass", "G300", 799.99m, 4.9m, "Glazed", 100.0m },
                    { new Guid("22222222-bbbb-4ccc-dddd-000000000003"), "Smooth steel door, ideal for modern apartments.", 205.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-2.webp", "Steel", "S250", 489.99m, 4.2m, "Smooth", 92.0m },
                    { new Guid("23456789-eeee-4fff-aaaa-000000000018"), "Smooth steel door with advanced security locks.", 210.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-secure.webp", "Steel", "S450", 629.99m, 4.6m, "Smooth", 95.0m },
                    { new Guid("33333333-cccc-4ddd-eeee-000000000004"), "Smooth aluminium door with matte finish.", 200.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-aluminium.webp", "Aluminium", "S300", 549.99m, 3.8m, "Smooth", 88.0m },
                    { new Guid("34567890-ffff-4aaa-bbbb-000000000019"), "Profiled steel door reinforced for extra security.", 210.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-secure.webp", "Steel", "P400", 669.99m, 4.5m, "Profiled", 94.0m },
                    { new Guid("44444444-dddd-4eee-ffff-000000000005"), "Profiled steel door with decorative panels.", 215.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-steel-door.webp", "Steel", "P100", 599.99m, 4.5m, "Profiled", 96.0m },
                    { new Guid("45678901-aaaa-4bbb-cccc-000000000020"), "Secure glazed steel door with impact-resistant glass.", 215.0m, "https://starkdoor.com/external/public_html/images/categories/stark-glazed-secure.webp", "Steel + Glass", "G350", 789.99m, 4.8m, "Glazed", 97.0m },
                    { new Guid("55555555-eeee-4fff-aaaa-000000000006"), "Profiled steel door with elegant frame.", 210.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-2.webp", "Steel", "P150", 569.99m, 4.3m, "Profiled", 94.0m },
                    { new Guid("56789012-bbbb-4ccc-dddd-000000000021"), "Eco-friendly smooth aluminium door with insulation.", 205.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-eco.webp", "Aluminium", "S500", 579.99m, 4.1m, "Smooth", 92.0m },
                    { new Guid("66666666-ffff-4aaa-bbbb-000000000007"), "Profiled wooden door with traditional design.", 205.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-wood.webp", "Wood", "P200", 649.99m, 4.0m, "Profiled", 90.0m },
                    { new Guid("77777777-aaaa-4bbb-cccc-000000000008"), "Profiled aluminium door with brushed surface.", 200.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-aluminium.webp", "Aluminium", "P250", 589.99m, 3.7m, "Profiled", 88.0m },
                    { new Guid("88888888-bbbb-4ccc-dddd-000000000009"), "Glazed steel door with tempered glass panel.", 215.0m, "https://starkdoor.com/external/public_html/images/categories/stark-glazed-steel-door.webp", "Steel + Glass", "G100", 699.99m, 4.8m, "Glazed", 98.0m },
                    { new Guid("99999999-cccc-4ddd-eeee-000000000010"), "Glazed steel door with frosted glass insert.", 210.0m, "https://starkdoor.com/external/public_html/images/categories/stark-glazed-2.webp", "Steel + Glass", "G150", 729.99m, 4.5m, "Glazed", 94.0m },
                    { new Guid("aaaaaaaa-dddd-4eee-ffff-000000000011"), "Glazed wooden door with decorative glass.", 205.0m, "https://starkdoor.com/external/public_html/images/categories/stark-glazed-wood.webp", "Wood + Glass", "G200", 759.99m, 4.2m, "Glazed", 92.0m },
                    { new Guid("bbbbbbbb-eeee-4fff-aaaa-000000000012"), "Smooth luxury steel door with premium coating.", 220.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-lux.webp", "Steel", "S350", 599.99m, 4.7m, "Smooth", 100.0m },
                    { new Guid("cccccccc-ffff-4aaa-bbbb-000000000013"), "Profiled steel door with ornate panel design.", 210.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-lux.webp", "Steel", "P300", 639.99m, 4.5m, "Profiled", 95.0m },
                    { new Guid("dddddddd-aaaa-4bbb-cccc-000000000014"), "Modern glazed door with clear glass panel.", 215.0m, "https://starkdoor.com/external/public_html/images/categories/stark-glazed-modern.webp", "Steel + Glass", "G250", 749.99m, 4.6m, "Glazed", 96.0m },
                    { new Guid("eeeeeeee-bbbb-4ccc-dddd-000000000015"), "Ultra-smooth aluminium door for contemporary homes.", 205.0m, "https://starkdoor.com/external/public_html/images/categories/stark-smooth-ultra.webp", "Aluminium", "S400", 559.99m, 4.0m, "Smooth", 93.0m },
                    { new Guid("ffffffff-cccc-4ddd-eeee-000000000016"), "Classic profiled wooden door with deep carvings.", 215.0m, "https://starkdoor.com/external/public_html/images/categories/stark-profiled-classic.webp", "Wood", "P350", 689.99m, 4.4m, "Profiled", 98.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_DoorId",
                table: "BasketItems",
                column: "DoorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("11111111-aaaa-4bbb-cccc-000000000002"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("12345678-dddd-4eee-ffff-000000000017"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("22222222-bbbb-4ccc-dddd-000000000003"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("23456789-eeee-4fff-aaaa-000000000018"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("33333333-cccc-4ddd-eeee-000000000004"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("34567890-ffff-4aaa-bbbb-000000000019"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("44444444-dddd-4eee-ffff-000000000005"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("45678901-aaaa-4bbb-cccc-000000000020"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("55555555-eeee-4fff-aaaa-000000000006"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("56789012-bbbb-4ccc-dddd-000000000021"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("66666666-ffff-4aaa-bbbb-000000000007"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("77777777-aaaa-4bbb-cccc-000000000008"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("88888888-bbbb-4ccc-dddd-000000000009"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("99999999-cccc-4ddd-eeee-000000000010"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("aaaaaaaa-dddd-4eee-ffff-000000000011"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("bbbbbbbb-eeee-4fff-aaaa-000000000012"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("cccccccc-ffff-4aaa-bbbb-000000000013"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("dddddddd-aaaa-4bbb-cccc-000000000014"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("eeeeeeee-bbbb-4ccc-dddd-000000000015"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("ffffffff-cccc-4ddd-eeee-000000000016"));

            migrationBuilder.CreateTable(
                name: "BasketDoors",
                columns: table => new
                {
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDoors", x => new { x.DoorId, x.BasketId });
                    table.ForeignKey(
                        name: "FK_BasketDoors_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDoors_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId");
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorId", "Description", "Height", "ImageUrl", "Material", "Model", "Price", "Thickness", "Type", "Width" },
                values: new object[,]
                {
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000001"), "High-quality steel door with modern design.", 200.0m, "https://starkdoor.com/external/public_html/images/categories/stark-premium-steel-doors.webp", "Steel", "S100", 499.99m, 4.5m, "Solid", 90.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000002"), "Elegant oak wood door with smooth finish.", 200.0m, "https://mla5dc5gjk9g.i.optimole.com/cb:ykaZ.3ba35/w:auto/h:auto/q:mauto/f:best/https://www.aspire-doors.co.uk/wp-content/uploads/2023/11/oak-mexicano-prefinished-lifestyle.jpg", "Oak Wood", "I200", 299.00m, 4.0m, "Laminated", 80.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000003"), "Stylish tempered glass door with reinforced frame.", 210.0m, "https://supplychaingamechanger.com/wp-content/uploads/2023/08/TemperedGlass.jpg", "Tempered Glass", "SL300", 399.50m, 3.5m, "Laminated", 100.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000004"), "Fireproof steel door suitable for safety exits.", 210.0m, "https://5.imimg.com/data5/EM/DU/NC/SELLER-8174112/man-door-500x500.png", "Steel with Fireproof Coating", "F400", 749.99m, 5.0m, "Solid", 90.0m },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000005"), "Lightweight aluminum door with modern aesthetics.", 220.0m, "https://www.glenviewdoors.com/ExteriorAluminum/gallery/Swing-Aluminum-Exterior-Door-with-Sidelites-EAL-SWS-W6-2SL.jpg", "Aluminum", "E500", 599.00m, 3.8m, "PVC", 100.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketDoors_BasketId",
                table: "BasketDoors",
                column: "BasketId");
        }
    }
}
