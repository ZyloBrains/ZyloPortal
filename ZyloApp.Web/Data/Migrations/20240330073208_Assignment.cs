using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Assignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedBy",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08f54e67-567c-4458-a4a4-ebc3080277ca", "08f54e67-567c-4458-a4a4-ebc3080277ca", "Trainee", "TRAINEE" },
                    { "0b3f2275-40bd-4289-97a4-553e06fb1b14", "0b3f2275-40bd-4289-97a4-553e06fb1b14", "Admin", "ADMIN" },
                    { "2b6593ca-86fd-4e53-aa36-81b7aa268cb0", "2b6593ca-86fd-4e53-aa36-81b7aa268cb0", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ab41496-242b-4173-bac4-438d92b32bf6", 0, "e1cf5cb6-95f4-425c-a1b2-a93090521f35", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEDh3A3Q4pURE6JaF/Uy/m7YcnoXQ5x2IQp7UKffAJaUpq1TNR4ulyKJe5vqeKyaKOw==", null, false, "d4a1e13f-c0a7-420d-bec6-0dd64902d5d2", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 17, 6, 222, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08f54e67-567c-4458-a4a4-ebc3080277ca", "5ab41496-242b-4173-bac4-438d92b32bf6" },
                    { "0b3f2275-40bd-4289-97a4-553e06fb1b14", "5ab41496-242b-4173-bac4-438d92b32bf6" },
                    { "2b6593ca-86fd-4e53-aa36-81b7aa268cb0", "5ab41496-242b-4173-bac4-438d92b32bf6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08f54e67-567c-4458-a4a4-ebc3080277ca", "5ab41496-242b-4173-bac4-438d92b32bf6" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0b3f2275-40bd-4289-97a4-553e06fb1b14", "5ab41496-242b-4173-bac4-438d92b32bf6" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b6593ca-86fd-4e53-aa36-81b7aa268cb0", "5ab41496-242b-4173-bac4-438d92b32bf6" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "08f54e67-567c-4458-a4a4-ebc3080277ca");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0b3f2275-40bd-4289-97a4-553e06fb1b14");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2b6593ca-86fd-4e53-aa36-81b7aa268cb0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5ab41496-242b-4173-bac4-438d92b32bf6");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "Projects");

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
    }
}
