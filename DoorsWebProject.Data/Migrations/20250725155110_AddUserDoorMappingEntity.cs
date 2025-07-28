using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserDoorMappingEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoorBasket_Doors_DoorId",
                table: "DoorBasket");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorCategory_Doors_DoorId",
                table: "DoorCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorColor_Doors_DoorId",
                table: "DoorColor");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorWishlist_Doors_DoorId",
                table: "DoorWishlist");

            migrationBuilder.CreateTable(
                name: "ApplicationUserDoors",
                columns: table => new
                {
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Foreign key to the referenced AspNetUser. Part of the entity composite PK"),
                    DoorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Foreign key to the referenced Door. Part of the entity composite PK"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "Show if ApplicationUserDoor entry is deleted")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDoors", x => new { x.ApplicationUserId, x.DoorId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserDoors_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDoors_Doors_DoorId",
                        column: x => x.DoorId,
                        principalTable: "Doors",
                        principalColumn: "DoorId",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "User Watchlist entry in the system");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDoors_DoorId",
                table: "ApplicationUserDoors",
                column: "DoorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoorBasket_Doors_DoorId",
                table: "DoorBasket",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCategory_Doors_DoorId",
                table: "DoorCategory",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoorColor_Doors_DoorId",
                table: "DoorColor",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoorWishlist_Doors_DoorId",
                table: "DoorWishlist",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoorBasket_Doors_DoorId",
                table: "DoorBasket");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorCategory_Doors_DoorId",
                table: "DoorCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorColor_Doors_DoorId",
                table: "DoorColor");

            migrationBuilder.DropForeignKey(
                name: "FK_DoorWishlist_Doors_DoorId",
                table: "DoorWishlist");

            migrationBuilder.DropTable(
                name: "ApplicationUserDoors");

            migrationBuilder.AddForeignKey(
                name: "FK_DoorBasket_Doors_DoorId",
                table: "DoorBasket",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoorCategory_Doors_DoorId",
                table: "DoorCategory",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoorColor_Doors_DoorId",
                table: "DoorColor",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoorWishlist_Doors_DoorId",
                table: "DoorWishlist",
                column: "DoorId",
                principalTable: "Doors",
                principalColumn: "DoorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
