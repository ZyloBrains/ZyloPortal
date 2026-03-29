using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReviewFormTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04d44b8d-3552-49be-abca-6cfc2244cbb8", "04d44b8d-3552-49be-abca-6cfc2244cbb8", "Trainee", "TRAINEE" },
                    { "147db436-ae21-4013-9c9f-021fb4cc0be7", "147db436-ae21-4013-9c9f-021fb4cc0be7", "Admin", "ADMIN" },
                    { "b7e7e660-a0d0-49b5-8219-221d53b22c24", "b7e7e660-a0d0-49b5-8219-221d53b22c24", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b1f8f620-62cd-42c6-8ac3-4835d6623c37", 0, "0a4f81bc-8c5d-4126-812e-1357ae97a343", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEF+wdpI6SD0+ezyr6EpZrsQ+0nM5CueORQe4vnjnMKvCO3LgI95PzILWkyP9cL0EpQ==", null, false, "daf37b0e-6c66-436b-b8a2-f5aa4e45e8c4", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "04d44b8d-3552-49be-abca-6cfc2244cbb8", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" },
                    { "147db436-ae21-4013-9c9f-021fb4cc0be7", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" },
                    { "b7e7e660-a0d0-49b5-8219-221d53b22c24", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d44b8d-3552-49be-abca-6cfc2244cbb8", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "147db436-ae21-4013-9c9f-021fb4cc0be7", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7e7e660-a0d0-49b5-8219-221d53b22c24", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "04d44b8d-3552-49be-abca-6cfc2244cbb8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "147db436-ae21-4013-9c9f-021fb4cc0be7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b7e7e660-a0d0-49b5-8219-221d53b22c24");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b1f8f620-62cd-42c6-8ac3-4835d6623c37");

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
    }
}
