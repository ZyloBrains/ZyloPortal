using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateExpense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6eda1ee2-7e0a-497f-8055-06e7f878efff", "abd84a25-b12d-4821-ad48-cb64ab4a4b08" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0c599f9-607a-4284-8cd1-a4e6c8f0ab79", "abd84a25-b12d-4821-ad48-cb64ab4a4b08" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ec61e5b4-cd53-4c41-811d-91eb3edb1b46", "abd84a25-b12d-4821-ad48-cb64ab4a4b08" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6eda1ee2-7e0a-497f-8055-06e7f878efff");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b0c599f9-607a-4284-8cd1-a4e6c8f0ab79");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ec61e5b4-cd53-4c41-811d-91eb3edb1b46");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "abd84a25-b12d-4821-ad48-cb64ab4a4b08");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "StudentAssignments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolutionUrl",
                table: "StudentAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberType",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "StudentAssignments");

            migrationBuilder.DropColumn(
                name: "SolutionUrl",
                table: "StudentAssignments");

            migrationBuilder.DropColumn(
                name: "MemberType",
                table: "Instructors");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6eda1ee2-7e0a-497f-8055-06e7f878efff", "6eda1ee2-7e0a-497f-8055-06e7f878efff", "Trainee", "TRAINEE" },
                    { "b0c599f9-607a-4284-8cd1-a4e6c8f0ab79", "b0c599f9-607a-4284-8cd1-a4e6c8f0ab79", "SuperAdmin", "SUPERADMIN" },
                    { "ec61e5b4-cd53-4c41-811d-91eb3edb1b46", "ec61e5b4-cd53-4c41-811d-91eb3edb1b46", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abd84a25-b12d-4821-ad48-cb64ab4a4b08", 0, "68cc7aeb-c911-4a2d-8be9-088bafb13658", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEO/3IQ+pk2eY9mD5l0iu7131Hmj1SNbxLS/3B4z9Vdj01DfNLTH1LEyjGO3bPbeEdQ==", null, false, "0138bcb5-600f-41cc-a8fa-ab1d0acc30c3", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 30, 13, 20, 12, 31, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6eda1ee2-7e0a-497f-8055-06e7f878efff", "abd84a25-b12d-4821-ad48-cb64ab4a4b08" },
                    { "b0c599f9-607a-4284-8cd1-a4e6c8f0ab79", "abd84a25-b12d-4821-ad48-cb64ab4a4b08" },
                    { "ec61e5b4-cd53-4c41-811d-91eb3edb1b46", "abd84a25-b12d-4821-ad48-cb64ab4a4b08" }
                });
        }
    }
}
