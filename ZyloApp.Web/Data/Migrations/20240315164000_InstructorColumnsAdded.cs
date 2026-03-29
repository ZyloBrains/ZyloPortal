using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class InstructorColumnsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ee98990-870d-4830-bab9-e5a4e8d950e1", "199a4fbe-5997-445c-95e0-a1c07450ab54" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4c44029-0b6f-4014-a2ec-329898cfea21", "199a4fbe-5997-445c-95e0-a1c07450ab54" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e47118c4-578e-4492-8d49-2984b544a344", "199a4fbe-5997-445c-95e0-a1c07450ab54" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3ee98990-870d-4830-bab9-e5a4e8d950e1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b4c44029-0b6f-4014-a2ec-329898cfea21");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e47118c4-578e-4492-8d49-2984b544a344");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "199a4fbe-5997-445c-95e0-a1c07450ab54");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Organization",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Organization",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Instructors");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ee98990-870d-4830-bab9-e5a4e8d950e1", "3ee98990-870d-4830-bab9-e5a4e8d950e1", "SuperAdmin", "SUPERADMIN" },
                    { "b4c44029-0b6f-4014-a2ec-329898cfea21", "b4c44029-0b6f-4014-a2ec-329898cfea21", "Trainee", "TRAINEE" },
                    { "e47118c4-578e-4492-8d49-2984b544a344", "e47118c4-578e-4492-8d49-2984b544a344", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "199a4fbe-5997-445c-95e0-a1c07450ab54", 0, "62303d91-bd47-45ee-92cc-b1c77cbc99c7", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEJXfI7MbRGFJGiL5AhEHVGRTkpTyJYJ3YaCA+Qzn3yuLtBCI+X/pE9Jz4mxVUcknbA==", null, false, "0c2b9784-e586-407b-b412-baa490ba53cc", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 15, 18, 16, 26, 100, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3ee98990-870d-4830-bab9-e5a4e8d950e1", "199a4fbe-5997-445c-95e0-a1c07450ab54" },
                    { "b4c44029-0b6f-4014-a2ec-329898cfea21", "199a4fbe-5997-445c-95e0-a1c07450ab54" },
                    { "e47118c4-578e-4492-8d49-2984b544a344", "199a4fbe-5997-445c-95e0-a1c07450ab54" }
                });
        }
    }
}
