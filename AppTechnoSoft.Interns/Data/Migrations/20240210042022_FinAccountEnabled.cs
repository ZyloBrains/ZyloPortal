using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinAccountEnabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "52a1c35a-e1c5-4466-8879-953a975a3bb1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "86b30e13-0c78-4436-b297-3993f840ba12");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "999556a0-4c04-45ad-84cc-811814e7a580", "21e10d3e-51e3-4f5f-ab21-7249ea386de9" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "999556a0-4c04-45ad-84cc-811814e7a580");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21e10d3e-51e3-4f5f-ab21-7249ea386de9");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "FinAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29148e4d-ec64-4b47-85c8-b18e75169eb3", "29148e4d-ec64-4b47-85c8-b18e75169eb3", "Admin", "ADMIN" },
                    { "2a7568fb-3f0f-4b18-a12f-16aa900b2d50", "2a7568fb-3f0f-4b18-a12f-16aa900b2d50", "Trainee", "TRAINEE" },
                    { "96c26fad-8f6d-4342-b59d-0c1717a876be", "96c26fad-8f6d-4342-b59d-0c1717a876be", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "67f95be8-a3a9-4fef-aa39-8a9dc41be743", 0, "f36d959e-f3aa-4dd1-9c6a-ee5f3e175cc4", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEJvTzw2CPVwae7wMdIX7SIgHpilwq9P5qDI6xwOS9pU2SenTWXM3cblqXNAYBEyx4g==", null, false, "22b12efd-04d7-4428-92ef-51f732657df6", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 10, 10, 5, 21, 993, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "96c26fad-8f6d-4342-b59d-0c1717a876be", "67f95be8-a3a9-4fef-aa39-8a9dc41be743" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "29148e4d-ec64-4b47-85c8-b18e75169eb3");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2a7568fb-3f0f-4b18-a12f-16aa900b2d50");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96c26fad-8f6d-4342-b59d-0c1717a876be", "67f95be8-a3a9-4fef-aa39-8a9dc41be743" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "96c26fad-8f6d-4342-b59d-0c1717a876be");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "67f95be8-a3a9-4fef-aa39-8a9dc41be743");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "FinAccounts");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52a1c35a-e1c5-4466-8879-953a975a3bb1", "52a1c35a-e1c5-4466-8879-953a975a3bb1", "Admin", "ADMIN" },
                    { "86b30e13-0c78-4436-b297-3993f840ba12", "86b30e13-0c78-4436-b297-3993f840ba12", "Trainee", "TRAINEE" },
                    { "999556a0-4c04-45ad-84cc-811814e7a580", "999556a0-4c04-45ad-84cc-811814e7a580", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21e10d3e-51e3-4f5f-ab21-7249ea386de9", 0, "42bba37d-b489-40d0-a28d-a590ceac5775", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEHqHch1v92ttjXAvWaX/EKEe6Rs/QFwTfG98yL/JwQLRfYf5jPWxxBGzcA8lyWXeqw==", null, false, "93b7aca7-b0e5-4b3f-a2dc-7823632cd996", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "999556a0-4c04-45ad-84cc-811814e7a580", "21e10d3e-51e3-4f5f-ab21-7249ea386de9" });
        }
    }
}
