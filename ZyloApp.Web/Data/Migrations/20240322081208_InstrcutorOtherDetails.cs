using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class InstrcutorOtherDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0834d198-cd95-48fd-a418-95f073fddb11", "6dab2695-1ee3-44d2-b017-5050d3059bd0" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b852d07-5fff-4f70-a74c-113c83d84026", "6dab2695-1ee3-44d2-b017-5050d3059bd0" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8672b3de-8cad-4a2f-9d1e-d13466cd3a80", "6dab2695-1ee3-44d2-b017-5050d3059bd0" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0834d198-cd95-48fd-a418-95f073fddb11");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5b852d07-5fff-4f70-a74c-113c83d84026");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8672b3de-8cad-4a2f-9d1e-d13466cd3a80");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6dab2695-1ee3-44d2-b017-5050d3059bd0");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "OtherDetails",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OtherDetails",
                table: "Instructors");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Organization",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0834d198-cd95-48fd-a418-95f073fddb11", "0834d198-cd95-48fd-a418-95f073fddb11", "SuperAdmin", "SUPERADMIN" },
                    { "5b852d07-5fff-4f70-a74c-113c83d84026", "5b852d07-5fff-4f70-a74c-113c83d84026", "Admin", "ADMIN" },
                    { "8672b3de-8cad-4a2f-9d1e-d13466cd3a80", "8672b3de-8cad-4a2f-9d1e-d13466cd3a80", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6dab2695-1ee3-44d2-b017-5050d3059bd0", 0, "417f9183-8100-4140-a35d-54fed8ac770e", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAECX5fxxLWB3+GwKDBkTmt+neHqstbnYINqpGXjd1F5v4cBkSpP8JzMoaqXcJdLNshw==", null, false, "bdeab9c6-a9fb-4fc7-a0b5-19a2ba5d5764", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 15, 22, 25, 0, 161, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0834d198-cd95-48fd-a418-95f073fddb11", "6dab2695-1ee3-44d2-b017-5050d3059bd0" },
                    { "5b852d07-5fff-4f70-a74c-113c83d84026", "6dab2695-1ee3-44d2-b017-5050d3059bd0" },
                    { "8672b3de-8cad-4a2f-9d1e-d13466cd3a80", "6dab2695-1ee3-44d2-b017-5050d3059bd0" }
                });
        }
    }
}
