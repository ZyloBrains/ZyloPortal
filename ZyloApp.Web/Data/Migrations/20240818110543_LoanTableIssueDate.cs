using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class LoanTableIssueDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce568225-e52c-4bfe-827c-d94a06267d7a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5372f38f-869e-48b4-9058-cd72b7b8ec6a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ce568225-e52c-4bfe-827c-d94a06267d7a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d2c40650-41e0-4ad1-ad78-fbecd4b58b55");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Loans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RepaymentDate",
                table: "Loans",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<float>(
                name: "Principal",
                table: "Loans",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "IntrestRate",
                table: "Loans",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<DateTime>(
                name: "IssueDate",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35f540c6-212a-4eb3-98f9-0238a08f4967", "35f540c6-212a-4eb3-98f9-0238a08f4967", "SuperAdmin", "SUPERADMIN" },
                    { "58cb2c61-e125-485c-85d7-0e854bcf6170", "58cb2c61-e125-485c-85d7-0e854bcf6170", "Trainee", "TRAINEE" },
                    { "eafb9bdc-99e3-46a5-8214-b04588c2155d", "eafb9bdc-99e3-46a5-8214-b04588c2155d", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "26db769f-6602-42e5-b6d4-074af1a8b7e6", 0, "72a1af26-0bca-493e-9b7e-ad8aca6af9aa", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEAObOLehWYHEtaFFtLQM2jcxZr/tMLTrKx6mQyTOcmotMYMwDvV3Z2kfpwbpnYzY/A==", null, false, "b8b11796-fb62-43e7-909f-c5f2e30374f6", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 18, 16, 50, 40, 598, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "35f540c6-212a-4eb3-98f9-0238a08f4967", "26db769f-6602-42e5-b6d4-074af1a8b7e6" },
                    { "58cb2c61-e125-485c-85d7-0e854bcf6170", "26db769f-6602-42e5-b6d4-074af1a8b7e6" },
                    { "eafb9bdc-99e3-46a5-8214-b04588c2155d", "26db769f-6602-42e5-b6d4-074af1a8b7e6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35f540c6-212a-4eb3-98f9-0238a08f4967", "26db769f-6602-42e5-b6d4-074af1a8b7e6" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "58cb2c61-e125-485c-85d7-0e854bcf6170", "26db769f-6602-42e5-b6d4-074af1a8b7e6" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eafb9bdc-99e3-46a5-8214-b04588c2155d", "26db769f-6602-42e5-b6d4-074af1a8b7e6" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "35f540c6-212a-4eb3-98f9-0238a08f4967");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "58cb2c61-e125-485c-85d7-0e854bcf6170");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "eafb9bdc-99e3-46a5-8214-b04588c2155d");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26db769f-6602-42e5-b6d4-074af1a8b7e6");

            migrationBuilder.DropColumn(
                name: "IssueDate",
                table: "Loans");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RepaymentDate",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Principal",
                table: "Loans",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "IntrestRate",
                table: "Loans",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Loans",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "Admin", "ADMIN" },
                    { "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "SuperAdmin", "SUPERADMIN" },
                    { "ce568225-e52c-4bfe-827c-d94a06267d7a", "ce568225-e52c-4bfe-827c-d94a06267d7a", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2c40650-41e0-4ad1-ad78-fbecd4b58b55", 0, "338cbaad-8de9-4891-8b97-03b4af3f4e1c", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEEFoCZFhQ7gKfteSx3NVH18jKy7whsQvWj2HUOR4SYp4Cnm1TYlsTUlU0Mo7bMzL3g==", null, false, "37661d20-f051-43a9-a351-dcea642c89e3", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" },
                    { "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" },
                    { "ce568225-e52c-4bfe-827c-d94a06267d7a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" }
                });
        }
    }
}
