using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class InstructorAddAppUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "90309be9-e358-45db-b947-648d05b07d16", "290e55b7-1959-4d73-bb4f-667e402ee595" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c83ad093-89aa-49a6-baaa-087cf8301438", "290e55b7-1959-4d73-bb4f-667e402ee595" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7556600-7150-46ea-862d-e3cbe8e98030", "290e55b7-1959-4d73-bb4f-667e402ee595" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "90309be9-e358-45db-b947-648d05b07d16");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c83ad093-89aa-49a6-baaa-087cf8301438");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d7556600-7150-46ea-862d-e3cbe8e98030");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "290e55b7-1959-4d73-bb4f-667e402ee595");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Instructors",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Users_ApplicationUserId",
                table: "Instructors",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Users_ApplicationUserId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ApplicationUserId",
                table: "Instructors");

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

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Instructors");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "90309be9-e358-45db-b947-648d05b07d16", "90309be9-e358-45db-b947-648d05b07d16", "Admin", "ADMIN" },
                    { "c83ad093-89aa-49a6-baaa-087cf8301438", "c83ad093-89aa-49a6-baaa-087cf8301438", "Trainee", "TRAINEE" },
                    { "d7556600-7150-46ea-862d-e3cbe8e98030", "d7556600-7150-46ea-862d-e3cbe8e98030", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "290e55b7-1959-4d73-bb4f-667e402ee595", 0, "4b298eaf-35dd-4265-8ea8-47e4767d1f8a", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEP8NssvQVXDwdH0yiavbQ53A3Df7DW3Ov4fzpto7tC3h9XRLDstijbpJd0yIjgIwlA==", null, false, "055ba833-9383-47f9-b3ff-9368ede7918c", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 6, 55, 310, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "90309be9-e358-45db-b947-648d05b07d16", "290e55b7-1959-4d73-bb4f-667e402ee595" },
                    { "c83ad093-89aa-49a6-baaa-087cf8301438", "290e55b7-1959-4d73-bb4f-667e402ee595" },
                    { "d7556600-7150-46ea-862d-e3cbe8e98030", "290e55b7-1959-4d73-bb4f-667e402ee595" }
                });
        }
    }
}
