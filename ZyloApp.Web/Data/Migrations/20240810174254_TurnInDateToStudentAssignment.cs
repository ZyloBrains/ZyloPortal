using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TurnInDateToStudentAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6412be14-bfe7-440f-a373-e2752f8692b9", "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7adb64a7-894f-4d64-b5d4-796a0fa39b89", "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b897649e-28c0-4ed0-831e-54396402d430", "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6412be14-bfe7-440f-a373-e2752f8692b9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7adb64a7-894f-4d64-b5d4-796a0fa39b89");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b897649e-28c0-4ed0-831e-54396402d430");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0");

            migrationBuilder.AddColumn<DateTime>(
                name: "TurnInDate",
                table: "StudentAssignments",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TurnInDate",
                table: "StudentAssignments");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6412be14-bfe7-440f-a373-e2752f8692b9", "6412be14-bfe7-440f-a373-e2752f8692b9", "Trainee", "TRAINEE" },
                    { "7adb64a7-894f-4d64-b5d4-796a0fa39b89", "7adb64a7-894f-4d64-b5d4-796a0fa39b89", "Admin", "ADMIN" },
                    { "b897649e-28c0-4ed0-831e-54396402d430", "b897649e-28c0-4ed0-831e-54396402d430", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0", 0, "fb220201-9a9d-443e-ad55-29ae67b95d3e", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEI5MzRdqn3eRFilZqiEh/ZnNzefppHOqzw6zuflANybg7Tbp8z8sysd78iricVdSbg==", null, false, "90aa2a5e-2ddb-40ba-a96b-c59989028c7d", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9219));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 7, 28, 15, 39, 28, 895, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6412be14-bfe7-440f-a373-e2752f8692b9", "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0" },
                    { "7adb64a7-894f-4d64-b5d4-796a0fa39b89", "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0" },
                    { "b897649e-28c0-4ed0-831e-54396402d430", "ce0d5df4-fc2c-4aac-9a45-8328b3e5fdc0" }
                });
        }
    }
}
