using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainingAssignmentsAndProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ad8d025-56da-49ce-8ada-3bf97ed433de", "a023dd75-3a54-4878-8cc9-a59b851cb393" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6177807-55ae-4a45-8731-de5626872d78", "a023dd75-3a54-4878-8cc9-a59b851cb393" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7e241a4-4305-4aca-9e12-6a7334d202a2", "a023dd75-3a54-4878-8cc9-a59b851cb393" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1ad8d025-56da-49ce-8ada-3bf97ed433de");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b6177807-55ae-4a45-8731-de5626872d78");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c7e241a4-4305-4aca-9e12-6a7334d202a2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a023dd75-3a54-4878-8cc9-a59b851cb393");

            migrationBuilder.CreateTable(
                name: "TrainingAssignments",
                columns: table => new
                {
                    AssignmentsId = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingAssignments", x => new { x.AssignmentsId, x.TrainingId });
                    table.ForeignKey(
                        name: "FK_TrainingAssignments_Assignments_AssignmentsId",
                        column: x => x.AssignmentsId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingAssignments_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingProjects",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingProjects", x => new { x.ProjectsId, x.TrainingId });
                    table.ForeignKey(
                        name: "FK_TrainingProjects_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingProjects_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TrainingAssignments_TrainingId",
                table: "TrainingAssignments",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProjects_TrainingId",
                table: "TrainingProjects",
                column: "TrainingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingAssignments");

            migrationBuilder.DropTable(
                name: "TrainingProjects");

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ad8d025-56da-49ce-8ada-3bf97ed433de", "1ad8d025-56da-49ce-8ada-3bf97ed433de", "Admin", "ADMIN" },
                    { "b6177807-55ae-4a45-8731-de5626872d78", "b6177807-55ae-4a45-8731-de5626872d78", "SuperAdmin", "SUPERADMIN" },
                    { "c7e241a4-4305-4aca-9e12-6a7334d202a2", "c7e241a4-4305-4aca-9e12-6a7334d202a2", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a023dd75-3a54-4878-8cc9-a59b851cb393", 0, "dea114b0-92a3-40f3-b599-1719fcacd30d", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAELFtPVjllB9VVJNIm9imKiQ46QeMqkl9wVSWbRJPR55h9YUbW2zY4q3TJ/sqBR8PNg==", null, false, "78150947-1952-486b-a3b9-f9e2670687e2", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1ad8d025-56da-49ce-8ada-3bf97ed433de", "a023dd75-3a54-4878-8cc9-a59b851cb393" },
                    { "b6177807-55ae-4a45-8731-de5626872d78", "a023dd75-3a54-4878-8cc9-a59b851cb393" },
                    { "c7e241a4-4305-4aca-9e12-6a7334d202a2", "a023dd75-3a54-4878-8cc9-a59b851cb393" }
                });
        }
    }
}
