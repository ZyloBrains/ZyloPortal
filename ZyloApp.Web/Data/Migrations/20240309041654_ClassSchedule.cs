using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClassSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "SuperAdmin", "SUPERADMIN" },
                    { "9730035d-aade-47fb-ac77-1ef1c3f397d1", "9730035d-aade-47fb-ac77-1ef1c3f397d1", "Trainee", "TRAINEE" },
                    { "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "068eb185-9fbc-4f03-82ec-1a2b91bd590c", 0, "294fe060-9787-4db0-b94b-8b3e7c781ce1", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEOKeEpOj3n4dR+v6s+JUXuJs9q8mZCv4AGgmCttyq/J2erjeohxa6DNmspQ8sdup/Q==", null, false, "611af537-ec36-4291-8996-9398bf01092f", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" },
                    { "9730035d-aade-47fb-ac77-1ef1c3f397d1", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" },
                    { "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9730035d-aade-47fb-ac77-1ef1c3f397d1", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9730035d-aade-47fb-ac77-1ef1c3f397d1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "068eb185-9fbc-4f03-82ec-1a2b91bd590c");

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
    }
}
