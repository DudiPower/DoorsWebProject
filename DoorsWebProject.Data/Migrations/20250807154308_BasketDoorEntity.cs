using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class BasketDoorEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoorBasket");

            migrationBuilder.CreateTable(
                name: "BasketDoors",
                columns: table => new
                {
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_BasketDoors_BasketId",
                table: "BasketDoors",
                column: "BasketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDoors");

            migrationBuilder.CreateTable(
                name: "DoorBasket",
                columns: table => new
                {
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorBasket", x => new { x.DoorId, x.BasketId });
                    table.ForeignKey(
                        name: "FK_DoorBasket_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoorBasket_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoorBasket_BasketId",
                table: "DoorBasket",
                column: "BasketId");
        }
    }
}
