using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Baskets",
                column: "BasketId",
                values: new object[]
                {
                    new Guid("11111111-aaaa-4bbb-8ccc-000000000001"),
                    new Guid("11111111-aaaa-4bbb-8ccc-000000000002"),
                    new Guid("11111111-aaaa-4bbb-8ccc-000000000003"),
                    new Guid("11111111-aaaa-4bbb-8ccc-000000000004"),
                    new Guid("11111111-aaaa-4bbb-8ccc-000000000005")
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a3b9d5e1-8e5f-4f7b-9c88-bc6fbc761211"), "Security Doors" },
                    { new Guid("b6e2f5c7-33dc-4c0e-920f-1a3fa7c6e9d2"), "Interior Doors" },
                    { new Guid("c9f0a6d5-2344-45c2-bbe2-50d207b8573d"), "Exterior Doors" },
                    { new Guid("d1a8e6c9-baf4-4e47-93d2-1cc9bcd69fe0"), "Fireproof Doors" },
                    { new Guid("e3f7c1a4-39c3-43d3-8369-c1d267bb4371"), "Sliding Doors" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                column: "WishlistId",
                values: new object[]
                {
                    new Guid("22222222-bbbb-4ccc-9ddd-000000000001"),
                    new Guid("22222222-bbbb-4ccc-9ddd-000000000002"),
                    new Guid("22222222-bbbb-4ccc-9ddd-000000000003"),
                    new Guid("22222222-bbbb-4ccc-9ddd-000000000004"),
                    new Guid("22222222-bbbb-4ccc-9ddd-000000000005")
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "BasketId", "CategoryId", "Material", "Model", "Price", "Size", "WishlistId" },
                values: new object[,]
                {
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000001"), new Guid("11111111-aaaa-4bbb-8ccc-000000000001"), new Guid("a3b9d5e1-8e5f-4f7b-9c88-bc6fbc761211"), "Steel", "S100", 499.99m, "90x200 cm", new Guid("22222222-bbbb-4ccc-9ddd-000000000001") },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000002"), new Guid("11111111-aaaa-4bbb-8ccc-000000000002"), new Guid("b6e2f5c7-33dc-4c0e-920f-1a3fa7c6e9d2"), "Oak Wood", "I200", 299.00m, "80x200 cm", new Guid("22222222-bbbb-4ccc-9ddd-000000000002") },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000003"), new Guid("11111111-aaaa-4bbb-8ccc-000000000003"), new Guid("e3f7c1a4-39c3-43d3-8369-c1d267bb4371"), "Tempered Glass", "SL300", 399.50m, "100x210 cm", new Guid("22222222-bbbb-4ccc-9ddd-000000000003") },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000004"), new Guid("11111111-aaaa-4bbb-8ccc-000000000004"), new Guid("d1a8e6c9-baf4-4e47-93d2-1cc9bcd69fe0"), "Steel with Fireproof Coating", "F400", 749.99m, "90x210 cm", new Guid("22222222-bbbb-4ccc-9ddd-000000000004") },
                    { new Guid("33333333-cccc-4ddd-aaaa-000000000005"), new Guid("11111111-aaaa-4bbb-8ccc-000000000005"), new Guid("c9f0a6d5-2344-45c2-bbe2-50d207b8573d"), "Aluminum", "E500", 599.00m, "100x220 cm", new Guid("22222222-bbbb-4ccc-9ddd-000000000005") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000001"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000002"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000003"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000004"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-4ddd-aaaa-000000000005"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketId",
                keyValue: new Guid("11111111-aaaa-4bbb-8ccc-000000000001"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketId",
                keyValue: new Guid("11111111-aaaa-4bbb-8ccc-000000000002"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketId",
                keyValue: new Guid("11111111-aaaa-4bbb-8ccc-000000000003"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketId",
                keyValue: new Guid("11111111-aaaa-4bbb-8ccc-000000000004"));

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "BasketId",
                keyValue: new Guid("11111111-aaaa-4bbb-8ccc-000000000005"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a3b9d5e1-8e5f-4f7b-9c88-bc6fbc761211"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6e2f5c7-33dc-4c0e-920f-1a3fa7c6e9d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9f0a6d5-2344-45c2-bbe2-50d207b8573d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d1a8e6c9-baf4-4e47-93d2-1cc9bcd69fe0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3f7c1a4-39c3-43d3-8369-c1d267bb4371"));

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "WishlistId",
                keyValue: new Guid("22222222-bbbb-4ccc-9ddd-000000000001"));

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "WishlistId",
                keyValue: new Guid("22222222-bbbb-4ccc-9ddd-000000000002"));

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "WishlistId",
                keyValue: new Guid("22222222-bbbb-4ccc-9ddd-000000000003"));

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "WishlistId",
                keyValue: new Guid("22222222-bbbb-4ccc-9ddd-000000000004"));

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "WishlistId",
                keyValue: new Guid("22222222-bbbb-4ccc-9ddd-000000000005"));
        }
    }
}
