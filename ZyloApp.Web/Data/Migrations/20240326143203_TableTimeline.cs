using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TableTimeline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f0d7250-9135-4491-ad3b-e9256a0c72ad", "bab647d0-ee25-4f51-9063-ecea16ade071" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7298c143-63b6-4b78-84c6-ef6f1755095b", "bab647d0-ee25-4f51-9063-ecea16ade071" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54", "bab647d0-ee25-4f51-9063-ecea16ade071" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1f0d7250-9135-4491-ad3b-e9256a0c72ad");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7298c143-63b6-4b78-84c6-ef6f1755095b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bab647d0-ee25-4f51-9063-ecea16ade071");

            migrationBuilder.CreateTable(
                name: "TraineeTimelines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeTimelines", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a2a72f4-3119-4f7f-a302-4303e2e271e5", "1a2a72f4-3119-4f7f-a302-4303e2e271e5", "Admin", "ADMIN" },
                    { "a9ea3935-c0a3-480f-9c1a-d1a8e836ca75", "a9ea3935-c0a3-480f-9c1a-d1a8e836ca75", "SuperAdmin", "SUPERADMIN" },
                    { "e93eaea3-8888-4794-89fa-683e4a79175e", "e93eaea3-8888-4794-89fa-683e4a79175e", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0b78234-8e98-421c-be5f-a0e9f1347b49", 0, "8991c6a1-f4e3-4fc5-8500-463ce033db31", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEPDOhcFJaz9ww7B9rVhq2pqqmX5tPmZJ0AL87Wa/NOcuO3fv/H2NZZnbmCOXNrRr1g==", null, false, "942cb5bf-ec8b-4f05-b0cd-4abfc7b0571d", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 26, 20, 17, 1, 978, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1a2a72f4-3119-4f7f-a302-4303e2e271e5", "d0b78234-8e98-421c-be5f-a0e9f1347b49" },
                    { "a9ea3935-c0a3-480f-9c1a-d1a8e836ca75", "d0b78234-8e98-421c-be5f-a0e9f1347b49" },
                    { "e93eaea3-8888-4794-89fa-683e4a79175e", "d0b78234-8e98-421c-be5f-a0e9f1347b49" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TraineeTimelines");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a2a72f4-3119-4f7f-a302-4303e2e271e5", "d0b78234-8e98-421c-be5f-a0e9f1347b49" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9ea3935-c0a3-480f-9c1a-d1a8e836ca75", "d0b78234-8e98-421c-be5f-a0e9f1347b49" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e93eaea3-8888-4794-89fa-683e4a79175e", "d0b78234-8e98-421c-be5f-a0e9f1347b49" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1a2a72f4-3119-4f7f-a302-4303e2e271e5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a9ea3935-c0a3-480f-9c1a-d1a8e836ca75");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e93eaea3-8888-4794-89fa-683e4a79175e");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d0b78234-8e98-421c-be5f-a0e9f1347b49");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f0d7250-9135-4491-ad3b-e9256a0c72ad", "1f0d7250-9135-4491-ad3b-e9256a0c72ad", "Admin", "ADMIN" },
                    { "7298c143-63b6-4b78-84c6-ef6f1755095b", "7298c143-63b6-4b78-84c6-ef6f1755095b", "Trainee", "TRAINEE" },
                    { "f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54", "f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bab647d0-ee25-4f51-9063-ecea16ade071", 0, "6ee5883b-9218-4012-a2de-16e833c70234", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEDKJSPN5oMXIlAdEHZ2hBw/ZOfXgXeDGnjHquIO2jDjBr4v1R7DV94hKdknLMgrLsg==", null, false, "52c53066-3129-487e-86ce-51da71aa6bbf", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 22, 4, 12, 7, 37, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1f0d7250-9135-4491-ad3b-e9256a0c72ad", "bab647d0-ee25-4f51-9063-ecea16ade071" },
                    { "7298c143-63b6-4b78-84c6-ef6f1755095b", "bab647d0-ee25-4f51-9063-ecea16ade071" },
                    { "f493ecc2-b7e7-4d2c-a8c9-345ab1ad1e54", "bab647d0-ee25-4f51-9063-ecea16ade071" }
                });
        }
    }
}
