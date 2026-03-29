using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssignmentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Widgets_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Evaluation = table.Column<byte>(type: "tinyint", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAssignments_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAssignments_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAssignments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ModuleId",
                table: "Assignments",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignments_AssignmentId",
                table: "StudentAssignments",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignments_InstructorId",
                table: "StudentAssignments",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignments_StudentId",
                table: "StudentAssignments",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAssignments");

            migrationBuilder.DropTable(
                name: "Assignments");

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
    }
}
