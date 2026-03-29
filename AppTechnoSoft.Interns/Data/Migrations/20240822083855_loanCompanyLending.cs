using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class loanCompanyLending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b1c1247-073c-474a-afa0-8f9daf59708c", "df59875d-48e0-42b3-9a17-05dc2383674a" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "29f2e2e5-b21b-448c-9e91-2d1eb776e444", "df59875d-48e0-42b3-9a17-05dc2383674a" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "637fe01c-32eb-47e8-a08d-19f49bc3beb8", "df59875d-48e0-42b3-9a17-05dc2383674a" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1b1c1247-073c-474a-afa0-8f9daf59708c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "29f2e2e5-b21b-448c-9e91-2d1eb776e444");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "637fe01c-32eb-47e8-a08d-19f49bc3beb8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "df59875d-48e0-42b3-9a17-05dc2383674a");

            migrationBuilder.AddColumn<bool>(
                name: "CompanyLending",
                table: "Loans",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63c9f4d3-8065-416a-9e89-f26198072bd6", "63c9f4d3-8065-416a-9e89-f26198072bd6", "SuperAdmin", "SUPERADMIN" },
                    { "76a2f40a-a0c8-4127-a473-e56313f8d611", "76a2f40a-a0c8-4127-a473-e56313f8d611", "Trainee", "TRAINEE" },
                    { "843d1859-8293-45f0-a47f-dc8aa61b2f51", "843d1859-8293-45f0-a47f-dc8aa61b2f51", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d21036ec-86fa-4fb9-916e-7bf71c4d3457", 0, "a4fa1586-92b4-45da-8c15-3a68c8261a4e", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEN+AnHHn3CygoPOXQyL8NuePMcAtQ9CLpydxlIUacVdd5Pamxi/gnEho0Roaz/T74Q==", null, false, "6aa54654-0a56-4a93-9fcc-57cc531cc448", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 22, 14, 23, 50, 220, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "63c9f4d3-8065-416a-9e89-f26198072bd6", "d21036ec-86fa-4fb9-916e-7bf71c4d3457" },
                    { "76a2f40a-a0c8-4127-a473-e56313f8d611", "d21036ec-86fa-4fb9-916e-7bf71c4d3457" },
                    { "843d1859-8293-45f0-a47f-dc8aa61b2f51", "d21036ec-86fa-4fb9-916e-7bf71c4d3457" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63c9f4d3-8065-416a-9e89-f26198072bd6", "d21036ec-86fa-4fb9-916e-7bf71c4d3457" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76a2f40a-a0c8-4127-a473-e56313f8d611", "d21036ec-86fa-4fb9-916e-7bf71c4d3457" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "843d1859-8293-45f0-a47f-dc8aa61b2f51", "d21036ec-86fa-4fb9-916e-7bf71c4d3457" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "63c9f4d3-8065-416a-9e89-f26198072bd6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "76a2f40a-a0c8-4127-a473-e56313f8d611");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "843d1859-8293-45f0-a47f-dc8aa61b2f51");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d21036ec-86fa-4fb9-916e-7bf71c4d3457");

            migrationBuilder.DropColumn(
                name: "CompanyLending",
                table: "Loans");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b1c1247-073c-474a-afa0-8f9daf59708c", "1b1c1247-073c-474a-afa0-8f9daf59708c", "Admin", "ADMIN" },
                    { "29f2e2e5-b21b-448c-9e91-2d1eb776e444", "29f2e2e5-b21b-448c-9e91-2d1eb776e444", "SuperAdmin", "SUPERADMIN" },
                    { "637fe01c-32eb-47e8-a08d-19f49bc3beb8", "637fe01c-32eb-47e8-a08d-19f49bc3beb8", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "df59875d-48e0-42b3-9a17-05dc2383674a", 0, "9a0242ff-a8f3-4838-96c7-69f99f992dda", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEJQsTtvNmHyIuuBxPCxggohXMI3oo6PMvraCjiBmAJbu3QCzRhpzi5W2xXg1n6XH0A==", null, false, "58a199b7-e291-45b9-9e23-4ccd9bc1bf77", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 22, 12, 50, 19, 630, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1b1c1247-073c-474a-afa0-8f9daf59708c", "df59875d-48e0-42b3-9a17-05dc2383674a" },
                    { "29f2e2e5-b21b-448c-9e91-2d1eb776e444", "df59875d-48e0-42b3-9a17-05dc2383674a" },
                    { "637fe01c-32eb-47e8-a08d-19f49bc3beb8", "df59875d-48e0-42b3-9a17-05dc2383674a" }
                });
        }
    }
}
