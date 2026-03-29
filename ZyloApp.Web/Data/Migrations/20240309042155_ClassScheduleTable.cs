using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ClassScheduleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9730035d-aade-47fb-ac77-1ef1c3f397d1", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9730035d-aade-47fb-ac77-1ef1c3f397d1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "068eb185-9fbc-4f03-82ec-1a2b91bd590c");

            migrationBuilder.CreateTable(
                name: "ClassSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationHours = table.Column<float>(type: "real", nullable: false),
                    MeetingDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: false),
                    WidgetId = table.Column<int>(type: "int", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalTable: "Widgets",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_BatchId",
                table: "ClassSchedules",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_InstructorId",
                table: "ClassSchedules",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_WidgetId",
                table: "ClassSchedules",
                column: "WidgetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSchedules");

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "SuperAdmin", "SUPERADMIN" },
                    { "9730035d-aade-47fb-ac77-1ef1c3f397d1", "9730035d-aade-47fb-ac77-1ef1c3f397d1", "Trainee", "TRAINEE" },
                    { "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "068eb185-9fbc-4f03-82ec-1a2b91bd590c", 0, "294fe060-9787-4db0-b94b-8b3e7c781ce1", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEOKeEpOj3n4dR+v6s+JUXuJs9q8mZCv4AGgmCttyq/J2erjeohxa6DNmspQ8sdup/Q==", null, false, "611af537-ec36-4291-8996-9398bf01092f", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 3, 9, 10, 1, 53, 144, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "14131e25-2a6a-4ff1-9cc1-c1d761d56d3c", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" },
                    { "9730035d-aade-47fb-ac77-1ef1c3f397d1", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" },
                    { "9d23edfe-95ff-4c72-b2e9-1303b5aa4a72", "068eb185-9fbc-4f03-82ec-1a2b91bd590c" }
                });
        }
    }
}
