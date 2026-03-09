using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDoorObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doors_AspNetUsers_ApplicationUserId",
                table: "Doors");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Doors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Doors_AspNetUsers_ApplicationUserId",
                table: "Doors",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doors_AspNetUsers_ApplicationUserId",
                table: "Doors");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "Doors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doors_AspNetUsers_ApplicationUserId",
                table: "Doors",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
