using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoorColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DoorColor",
                columns: new[] { "ColorId", "DoorId" },
                values: new object[,]
                {
                    { new Guid("65a39814-a1cc-4a57-96e2-4afc22fd4d2a"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") },
                    { new Guid("be968e0c-5802-4898-a60f-097fa2df63b5"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") },
                    { new Guid("d9f1e7c2-69ea-442c-8284-42f6343f0898"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") },
                    { new Guid("e099139e-4a0a-4c2b-a62e-45b5299f4ea9"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DoorColor",
                keyColumns: new[] { "ColorId", "DoorId" },
                keyValues: new object[] { new Guid("65a39814-a1cc-4a57-96e2-4afc22fd4d2a"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") });

            migrationBuilder.DeleteData(
                table: "DoorColor",
                keyColumns: new[] { "ColorId", "DoorId" },
                keyValues: new object[] { new Guid("be968e0c-5802-4898-a60f-097fa2df63b5"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") });

            migrationBuilder.DeleteData(
                table: "DoorColor",
                keyColumns: new[] { "ColorId", "DoorId" },
                keyValues: new object[] { new Guid("d9f1e7c2-69ea-442c-8284-42f6343f0898"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") });

            migrationBuilder.DeleteData(
                table: "DoorColor",
                keyColumns: new[] { "ColorId", "DoorId" },
                keyValues: new object[] { new Guid("e099139e-4a0a-4c2b-a62e-45b5299f4ea9"), new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13") });
        }
    }
}
