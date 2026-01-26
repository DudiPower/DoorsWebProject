using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TextureUrl",
                table: "Colors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BasketDetails",
                columns: table => new
                {
                    BasketDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => x.BasketDetailId);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    OrderStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatuses",
                        principalColumn: "OrderStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "HexCode", "NameColor", "TextureUrl" },
                values: new object[,]
                {
                    { new Guid("0f65c147-aa61-495e-a597-963b6ee6a36c"), "#42291A", "Орех", "/textures/wooden-textured-background.jpg" },
                    { new Guid("2b90c521-fe5c-4d18-b529-eb9f2b545efb"), "#D8B589", "Дъб", "/textures/wooden-textured-background.jpg" },
                    { new Guid("43f687c1-3b7b-4611-833f-e11cf5c5e1f2"), "#7B2716", "Череша", "/textures/wooden-textured-background.jpg" },
                    { new Guid("48df69c8-8082-41a4-9a49-f76e66e3f1bc"), "#C04000", "Махагон", "/textures/wooden-textured-background.jpg" },
                    { new Guid("4c462fcc-14b2-4af1-8c54-dbb6db5b15dc"), "#B5833D", "Златен дъб", "/textures/wooden-textured-background.jpg" },
                    { new Guid("623c8827-062e-43a9-bc87-763c47363aba"), "#016388", "Синьо", "/textures/wooden-textured-background.jpg" },
                    { new Guid("649f1a32-4928-48b2-947d-599df8748d6f"), "#F1C38E", "Явор", "/textures/wooden-textured-background.jpg" },
                    { new Guid("65a39814-a1cc-4a57-96e2-4afc22fd4d2a"), "#A48071", "Ясен", "/textures/wooden-textured-background.jpg" },
                    { new Guid("be968e0c-5802-4898-a60f-097fa2df63b5"), "#2E6F40", "Зелено", "/textures/wooden-textured-background.jpg" },
                    { new Guid("d9f1e7c2-69ea-442c-8284-42f6343f0898"), "#645452", "Венге", "/textures/wooden-textured-background.jpg" },
                    { new Guid("e099139e-4a0a-4c2b-a62e-45b5299f4ea9"), "#1a1818", "Черно", "/textures/wooden-textured-background.jpg" },
                    { new Guid("e19eaf04-246f-4669-9a3e-a5158ba86306"), "#504c4b", "Сив дъб", "/textures/wooden-textured-background.jpg" },
                    { new Guid("f5483f5f-9fc3-4651-8c2b-637eebabfa8f"), "#FFFFFF", "Бяло", "/textures/wooden-textured-background.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_BasketId",
                table: "BasketDetails",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_DoorId",
                table: "BasketDetails",
                column: "DoorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_DoorId",
                table: "OrderDetails",
                column: "DoorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("0f65c147-aa61-495e-a597-963b6ee6a36c"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("2b90c521-fe5c-4d18-b529-eb9f2b545efb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("43f687c1-3b7b-4611-833f-e11cf5c5e1f2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("48df69c8-8082-41a4-9a49-f76e66e3f1bc"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("4c462fcc-14b2-4af1-8c54-dbb6db5b15dc"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("623c8827-062e-43a9-bc87-763c47363aba"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("649f1a32-4928-48b2-947d-599df8748d6f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("65a39814-a1cc-4a57-96e2-4afc22fd4d2a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("be968e0c-5802-4898-a60f-097fa2df63b5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("d9f1e7c2-69ea-442c-8284-42f6343f0898"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("e099139e-4a0a-4c2b-a62e-45b5299f4ea9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("e19eaf04-246f-4669-9a3e-a5158ba86306"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: new Guid("f5483f5f-9fc3-4651-8c2b-637eebabfa8f"));

            migrationBuilder.DropColumn(
                name: "TextureUrl",
                table: "Colors");
        }
    }
}
