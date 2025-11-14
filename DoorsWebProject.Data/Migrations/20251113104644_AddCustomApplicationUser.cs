using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_UserId",
                table: "Baskets");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "DoorWishlist");

            migrationBuilder.DropTable(
                name: "Wishlists");

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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Baskets",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                newName: "IX_Baskets_ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Doors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateIndex(
                name: "IX_Doors_ApplicationUserId",
                table: "Doors",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_ApplicationUserId",
                table: "Baskets",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doors_AspNetUsers_ApplicationUserId",
                table: "Doors",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_ApplicationUserId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_Doors_AspNetUsers_ApplicationUserId",
                table: "Doors");

            migrationBuilder.DropIndex(
                name: "IX_Doors_ApplicationUserId",
                table: "Doors");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Doors");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Baskets",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_ApplicationUserId",
                table: "Baskets",
                newName: "IX_Baskets_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    WishlistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.WishlistId);
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoorWishlist",
                columns: table => new
                {
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WishlistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorWishlist", x => new { x.DoorId, x.WishlistId });
                    table.ForeignKey(
                        name: "FK_DoorWishlist_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId");
                    table.ForeignKey(
                        name: "FK_DoorWishlist_Wishlists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "WishlistId",
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

            migrationBuilder.CreateIndex(
                name: "IX_DoorWishlist_WishlistId",
                table: "DoorWishlist",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_UserId",
                table: "Wishlists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_UserId",
                table: "Baskets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
