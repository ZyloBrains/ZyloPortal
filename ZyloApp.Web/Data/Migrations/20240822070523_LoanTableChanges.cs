using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class LoanTableChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IntrestRate",
                table: "Loans");

            migrationBuilder.AlterColumn<float>(
                name: "Principal",
                table: "Loans",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "InterestRate",
                table: "Loans",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "InterestRate",
                table: "Loans");

            migrationBuilder.AlterColumn<float>(
                name: "Principal",
                table: "Loans",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<float>(
                name: "IntrestRate",
                table: "Loans",
                type: "real",
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
    }
}
