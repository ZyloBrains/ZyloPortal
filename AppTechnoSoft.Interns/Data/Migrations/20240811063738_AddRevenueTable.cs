using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRevenueTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "440c7299-b96b-422d-bcca-434722554479", "d57540ac-35ac-44db-aa6b-1d03b76aef50" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "448aa617-d69a-4f33-910b-fc3e1adf3672", "d57540ac-35ac-44db-aa6b-1d03b76aef50" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e020d19-29f1-4534-8f22-4c12eff9b411", "d57540ac-35ac-44db-aa6b-1d03b76aef50" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "440c7299-b96b-422d-bcca-434722554479");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "448aa617-d69a-4f33-910b-fc3e1adf3672");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5e020d19-29f1-4534-8f22-4c12eff9b411");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d57540ac-35ac-44db-aa6b-1d03b76aef50");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8725b030-f785-4792-9acf-573d896667c0", "8725b030-f785-4792-9acf-573d896667c0", "Admin", "ADMIN" },
                    { "c55f080a-26b8-4311-b6fe-0be9b75c3035", "c55f080a-26b8-4311-b6fe-0be9b75c3035", "SuperAdmin", "SUPERADMIN" },
                    { "e311b665-c9ae-4712-9206-00f53a8f648a", "e311b665-c9ae-4712-9206-00f53a8f648a", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc0ef707-d24c-4963-ab52-a51af2d934c9", 0, "6aaf8b45-11b2-47e0-875a-c70f53964546", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEHQheufST/DR0/cwJdOvX5ajLsBsuauDnd9XKu8ChIdf7+jfdYrCx35VIbfTEYkkyQ==", null, false, "111ec06b-b44b-48a5-a659-3cc5696c183a", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8725b030-f785-4792-9acf-573d896667c0", "dc0ef707-d24c-4963-ab52-a51af2d934c9" },
                    { "c55f080a-26b8-4311-b6fe-0be9b75c3035", "dc0ef707-d24c-4963-ab52-a51af2d934c9" },
                    { "e311b665-c9ae-4712-9206-00f53a8f648a", "dc0ef707-d24c-4963-ab52-a51af2d934c9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8725b030-f785-4792-9acf-573d896667c0", "dc0ef707-d24c-4963-ab52-a51af2d934c9" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c55f080a-26b8-4311-b6fe-0be9b75c3035", "dc0ef707-d24c-4963-ab52-a51af2d934c9" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e311b665-c9ae-4712-9206-00f53a8f648a", "dc0ef707-d24c-4963-ab52-a51af2d934c9" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8725b030-f785-4792-9acf-573d896667c0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c55f080a-26b8-4311-b6fe-0be9b75c3035");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e311b665-c9ae-4712-9206-00f53a8f648a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dc0ef707-d24c-4963-ab52-a51af2d934c9");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "440c7299-b96b-422d-bcca-434722554479", "440c7299-b96b-422d-bcca-434722554479", "Admin", "ADMIN" },
                    { "448aa617-d69a-4f33-910b-fc3e1adf3672", "448aa617-d69a-4f33-910b-fc3e1adf3672", "Trainee", "TRAINEE" },
                    { "5e020d19-29f1-4534-8f22-4c12eff9b411", "5e020d19-29f1-4534-8f22-4c12eff9b411", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d57540ac-35ac-44db-aa6b-1d03b76aef50", 0, "21f02fa5-21ff-4197-b230-6e5501020cab", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEJ9r6eLuJIZoU+SN6/bliF8I8SsmMSfSz6hCupuDRThau+rtZ8I7sZmpSOigkOJUrw==", null, false, "83b9b244-16b6-4b78-a182-5bcba45b3724", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 10, 23, 27, 50, 257, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "440c7299-b96b-422d-bcca-434722554479", "d57540ac-35ac-44db-aa6b-1d03b76aef50" },
                    { "448aa617-d69a-4f33-910b-fc3e1adf3672", "d57540ac-35ac-44db-aa6b-1d03b76aef50" },
                    { "5e020d19-29f1-4534-8f22-4c12eff9b411", "d57540ac-35ac-44db-aa6b-1d03b76aef50" }
                });
        }
    }
}
