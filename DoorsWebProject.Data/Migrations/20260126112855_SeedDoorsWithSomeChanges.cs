using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoorsWebProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoorsWithSomeChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Material",
                table: "Doors");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Doors",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "BasketDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "DoorId", "ApplicationUserId", "Description", "Height", "ImageUrl", "Model", "Price", "Thickness", "Type", "Width" },
                values: new object[,]
                {
                    { new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13"), "b12cdb67-7ae7-4ae7-a7d0-22815749c41f", null, 200m, "https://galiardi.biz/wp-content/uploads/2019/01/t-100-antik-01-552213818-450x450.png", "А-102-Антик", 835.00m, 35m, "Armored", 90m },
                    { new Guid("1d6842c1-474f-4688-bdff-dc3abb83a3d2"), "eef7fb7b-a155-419a-a7f7-6b6fc865ae03", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%96%D0%95%D0%9D%D0%95%D0%92%D0%90-%D0%AF%D0%A1%D0%95%D0%9D-1013-300-680.png", "P-654", 915.00m, 35m, "Profiled", 90m },
                    { new Guid("20c499b1-ed63-4576-acba-1b9c61a66e2b"), "bee1ccb1-7179-4d28-a154-2dbb5f88c189", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%9B%D0%95%D0%99%D0%94%D0%98-%D0%93%D0%9B%D0%90%D0%A1-300%D1%85600.png", "G-955", 1215.00m, 35m, "Glazed", 90m },
                    { new Guid("2bc078ce-7786-4362-b936-1a0c21140201"), "eef7fb7b-a155-419a-a7f7-6b6fc865ae03", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/LONDON-48-SINEMORETC-300-670.png", "P-655", 930.00m, 35m, "Profiled", 90m },
                    { new Guid("3ba1296e-029f-42c0-8f43-414a6a3650bc"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/0008europe.jpg", "P-652", 915.00m, 35m, "Profiled", 90m },
                    { new Guid("40b2ed36-b35c-4016-b998-863038968490"), "b12cdb67-7ae7-4ae7-a7d0-22815749c41f", null, 200m, "https://galiardi.biz/wp-content/uploads/2019/01/t-100-africa-01-940834835-450x450.png", "А-101 Африка", 890.00m, 35m, "Armored", 90m },
                    { new Guid("55e5d4dc-a4fc-4fcd-aed1-4e688e63a547"), "bee1ccb1-7179-4d28-a154-2dbb5f88c189", null, 200m, "https://galiardi.biz/wp-content/uploads/2019/01/t-108-1228496364-450x450-300x300.png", "А-103-Орех", 800.00m, 35m, "Armored", 90m },
                    { new Guid("5fd5662d-99b7-4bee-b0dd-1c4f6837e387"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://karabulev.eu/wp-content/uploads/2018/04/tech-dab-01-300-670.jpg", "S-132", 835.00m, 35m, "Smooth", 90m },
                    { new Guid("63ab936a-7fa3-4578-99f6-dcd8608baad1"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://www.idialvrati.com/cache/images/4561.jpg", "W-236-Боряна", 1250.00m, 35m, "Wooden", 90m },
                    { new Guid("648047b3-6e61-4932-9f22-48792f58b911"), "eef7fb7b-a155-419a-a7f7-6b6fc865ae03", null, 200m, "https://www.idialvrati.com/cache/images/4556.jpg", "W-237-Лидия", 1300.00m, 35m, "Wooden", 90m },
                    { new Guid("70552a44-2166-4aa2-a114-a40f7b31bdb9"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%A7%D0%95%D0%A0%D0%95%D0%A8%D0%90-%D0%A0%D0%98%D0%9C.png", "P-651", 915.00m, 35m, "Profiled", 90m },
                    { new Guid("7099f6ff-e9a5-4204-bc0a-5abadc7e57d0"), "bee1ccb1-7179-4d28-a154-2dbb5f88c189", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%9C%D0%9B%D0%90%D0%94%D0%9E%D0%A1%D0%A2-05%D0%90.png", "G-954", 1180.00m, 35m, "Glazed", 90m },
                    { new Guid("8b59a026-9c22-4e66-a5e5-f2eb2fe22663"), "b12cdb67-7ae7-4ae7-a7d0-22815749c41f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/03/0007color.jpg", "S-134", 805.00m, 35m, "Smooth", 90m },
                    { new Guid("8e8904a5-de04-4f1e-a78b-6d24bd7ea78a"), "b12cdb67-7ae7-4ae7-a7d0-22815749c41f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/0000prestige.jpg", "S-135", 1280.00m, 35m, "Smooth", 90m },
                    { new Guid("988fbb66-32b9-4dd0-8458-e0202b5c4816"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/03/%D0%9B%D0%90%D0%9C%D0%98%D0%9D%D0%90%D0%A2_%D0%9E%D0%A0%D0%95%D0%A5-%D0%9A%D0%9E%D0%A0%D0%A1%D0%98%D0%9A%D0%90.png", "S-131", 635.00m, 35m, "Smooth", 90m },
                    { new Guid("c09bac80-7531-49b3-b147-b8e0377ad093"), "eef7fb7b-a155-419a-a7f7-6b6fc865ae03", null, 200m, "https://www.idialvrati.com/cache/images/4559.jpg", "W-238-Яна", 1200.00m, 35m, "Wooden", 90m },
                    { new Guid("c829575d-b139-4137-a8c9-4e1d22d35a53"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/0002tetris.jpg", "G-951", 1300.00m, 35m, "Glazed", 90m },
                    { new Guid("c8f0a9bc-920c-4435-bf39-e2f462640b4b"), "eef7fb7b-a155-419a-a7f7-6b6fc865ae03", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%92%D0%95%D0%9D%D0%95%D0%A6%D0%98%D0%AF-300-670.png", "P-653", 975.00m, 35m, "Profiled", 90m },
                    { new Guid("ccc7397a-f7c6-46cd-9510-5dedb05a30f2"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://www.idialvrati.com/cache/images/4509.jpg", "W-239-Синитово", 2500.00m, 35m, "Wooden", 90m },
                    { new Guid("d8738414-dbbe-465f-945b-492214473c3d"), "bee1ccb1-7179-4d28-a154-2dbb5f88c189", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%A1%D0%98%D0%9B%D0%A3%D0%95%D0%A2-%D0%9E%D0%A0%D0%95%D0%A5-%D0%9B%D0%90%D0%93%D0%A3%D0%9D%D0%901.png", "G-953", 1080.00m, 35m, "Glazed", 90m },
                    { new Guid("e37f55fd-1f7b-40f2-9374-e881b95c4506"), "eef7fb7b-a155-419a-a7f7-6b6fc865ae03", null, 200m, "https://galiardi.biz/wp-content/uploads/2019/01/t-587-zebra-01-71555585-450x450.png", "А-105-Зебра", 900.00m, 35m, "Armored", 90m },
                    { new Guid("ec7dce3e-9fb9-4857-9148-4ea9b776ba24"), "b12cdb67-7ae7-4ae7-a7d0-22815749c41f", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/03/INTARZIA-1.png", "S-133", 915.00m, 35m, "Smooth", 90m },
                    { new Guid("eddf2e0d-ed9d-431b-90d1-8af284e5289b"), "bee1ccb1-7179-4d28-a154-2dbb5f88c189", null, 200m, "https://galiardi.biz/wp-content/uploads/2019/01/t-110-sparta-01-450x450.png", "А-104-Спарта", 870.00m, 35m, "Armored", 90m },
                    { new Guid("ef13a19f-4149-4b92-92f9-bbd3d2ce5e53"), "8b116c3a-c340-40e8-b6a3-a6b512e9fb2f", null, 200m, "https://www.idialvrati.com/cache/images/4563.jpg", "W-235-Алина", 1280.00m, 35m, "Wooden", 90m },
                    { new Guid("fb98b190-80d7-42fd-a0a4-d1421ea03970"), "bee1ccb1-7179-4d28-a154-2dbb5f88c189", null, 200m, "https://karabulev.eu/wp-content/uploads/2017/04/%D0%AF%D0%A1%D0%95%D0%9D-1013-storgozia14.png", "G-952", 1200.00m, 35m, "Glazed", 90m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("06ebf95c-7758-4ce2-afb3-191d3c57fe13"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("1d6842c1-474f-4688-bdff-dc3abb83a3d2"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("20c499b1-ed63-4576-acba-1b9c61a66e2b"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("2bc078ce-7786-4362-b936-1a0c21140201"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("3ba1296e-029f-42c0-8f43-414a6a3650bc"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("40b2ed36-b35c-4016-b998-863038968490"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("55e5d4dc-a4fc-4fcd-aed1-4e688e63a547"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("5fd5662d-99b7-4bee-b0dd-1c4f6837e387"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("63ab936a-7fa3-4578-99f6-dcd8608baad1"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("648047b3-6e61-4932-9f22-48792f58b911"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("70552a44-2166-4aa2-a114-a40f7b31bdb9"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("7099f6ff-e9a5-4204-bc0a-5abadc7e57d0"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("8b59a026-9c22-4e66-a5e5-f2eb2fe22663"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("8e8904a5-de04-4f1e-a78b-6d24bd7ea78a"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("988fbb66-32b9-4dd0-8458-e0202b5c4816"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("c09bac80-7531-49b3-b147-b8e0377ad093"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("c829575d-b139-4137-a8c9-4e1d22d35a53"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("c8f0a9bc-920c-4435-bf39-e2f462640b4b"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("ccc7397a-f7c6-46cd-9510-5dedb05a30f2"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("d8738414-dbbe-465f-945b-492214473c3d"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("e37f55fd-1f7b-40f2-9374-e881b95c4506"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("ec7dce3e-9fb9-4857-9148-4ea9b776ba24"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("eddf2e0d-ed9d-431b-90d1-8af284e5289b"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("ef13a19f-4149-4b92-92f9-bbd3d2ce5e53"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "DoorId",
                keyValue: new Guid("fb98b190-80d7-42fd-a0a4-d1421ea03970"));

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "BasketDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Doors",
                type: "nvarchar(2500)",
                maxLength: 2500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(2500)",
                oldMaxLength: 2500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "Doors",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
