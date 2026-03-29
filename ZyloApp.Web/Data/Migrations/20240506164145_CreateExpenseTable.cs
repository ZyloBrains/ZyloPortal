using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateExpenseTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d1773ee-b17b-4e68-abef-1501f1681fb4", "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e76db83-6a65-428e-b0ce-d6e4499f7048", "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e60d7dcb-9bb3-411a-9f7c-fe5306dcf586", "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5d1773ee-b17b-4e68-abef-1501f1681fb4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5e76db83-6a65-428e-b0ce-d6e4499f7048");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e60d7dcb-9bb3-411a-9f7c-fe5306dcf586");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e");

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    ExpenseType = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "SuperAdmin", "SUPERADMIN" },
                    { "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "Trainee", "TRAINEE" },
                    { "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa", 0, "ede86e36-d51d-4114-aeaa-ee879272f24c", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEGDI5OzEK/w6FAeDg/f7xOuRGwwIC+9wWmatw6TzI77twMCQdmZ1MOUIMGYa1x+M0w==", null, false, "4bf7fe05-c8c4-4b34-8be9-d71a3da25167", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" },
                    { "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" },
                    { "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "64d9897d-8f09-4945-bc3d-f01f7bc847fe");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66aa88b4-c31d-4ebe-8b26-5912d8ceb778");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d1773ee-b17b-4e68-abef-1501f1681fb4", "5d1773ee-b17b-4e68-abef-1501f1681fb4", "SuperAdmin", "SUPERADMIN" },
                    { "5e76db83-6a65-428e-b0ce-d6e4499f7048", "5e76db83-6a65-428e-b0ce-d6e4499f7048", "Trainee", "TRAINEE" },
                    { "e60d7dcb-9bb3-411a-9f7c-fe5306dcf586", "e60d7dcb-9bb3-411a-9f7c-fe5306dcf586", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e", 0, "2772934e-87e8-4336-9f9f-c48add513b71", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEAGUR36kYpx3Iqc8CeyBOEnXcrXCCvUbbf+AgXTc5ZgZe9Ot923+A0lNYLsLIvUEwg==", null, false, "b77cf0b4-8e53-4f3a-95c2-c7ffe75a1675", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 17, 24, 462, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5d1773ee-b17b-4e68-abef-1501f1681fb4", "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e" },
                    { "5e76db83-6a65-428e-b0ce-d6e4499f7048", "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e" },
                    { "e60d7dcb-9bb3-411a-9f7c-fe5306dcf586", "e525b4f3-b2b0-4ae1-aaf8-8c4e5a592e5e" }
                });
        }
    }
}
