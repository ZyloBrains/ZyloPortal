using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateBatchBudget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "64d9897d-8f09-4945-bc3d-f01f7bc847fe");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "66aa88b4-c31d-4ebe-8b26-5912d8ceb778");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa");

            migrationBuilder.CreateTable(
                name: "BatchBudgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetType = table.Column<int>(type: "int", nullable: false),
                    Allocation = table.Column<float>(type: "real", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchBudgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatchBudgets_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7", "450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7", "Admin", "ADMIN" },
                    { "bc7d8682-0811-4485-bd18-cb75edf7b627", "bc7d8682-0811-4485-bd18-cb75edf7b627", "SuperAdmin", "SUPERADMIN" },
                    { "e9f31735-cc6a-4e5f-8d44-8c7316187d80", "e9f31735-cc6a-4e5f-8d44-8c7316187d80", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30cb352f-d79a-4464-94b5-3ccfedb04e50", 0, "50edc872-2345-46c8-8101-d138ae252c82", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEPYjjKrZ94+F3CP5LOmB1Bpt4N55P1AKHC2dfG2VeIg7DGk6EEi6yhx35o5zYjmhiA==", null, false, "b9d42617-13da-4063-bdfa-051e99d183e8", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 10, 15, 58, 14, 58, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7", "30cb352f-d79a-4464-94b5-3ccfedb04e50" },
                    { "bc7d8682-0811-4485-bd18-cb75edf7b627", "30cb352f-d79a-4464-94b5-3ccfedb04e50" },
                    { "e9f31735-cc6a-4e5f-8d44-8c7316187d80", "30cb352f-d79a-4464-94b5-3ccfedb04e50" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatchBudgets_BatchId",
                table: "BatchBudgets",
                column: "BatchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchBudgets");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7", "30cb352f-d79a-4464-94b5-3ccfedb04e50" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc7d8682-0811-4485-bd18-cb75edf7b627", "30cb352f-d79a-4464-94b5-3ccfedb04e50" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9f31735-cc6a-4e5f-8d44-8c7316187d80", "30cb352f-d79a-4464-94b5-3ccfedb04e50" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "450dc6cf-81f2-4ea1-9ac9-9e337d5a69f7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bc7d8682-0811-4485-bd18-cb75edf7b627");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e9f31735-cc6a-4e5f-8d44-8c7316187d80");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30cb352f-d79a-4464-94b5-3ccfedb04e50");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "SuperAdmin", "SUPERADMIN" },
                    { "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "Trainee", "TRAINEE" },
                    { "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa", 0, "ede86e36-d51d-4114-aeaa-ee879272f24c", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEGDI5OzEK/w6FAeDg/f7xOuRGwwIC+9wWmatw6TzI77twMCQdmZ1MOUIMGYa1x+M0w==", null, false, "4bf7fe05-c8c4-4b34-8be9-d71a3da25167", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 6, 22, 26, 44, 601, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3f9a2312-2e00-4365-a0b3-5d6fbc3e7948", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" },
                    { "64d9897d-8f09-4945-bc3d-f01f7bc847fe", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" },
                    { "66aa88b4-c31d-4ebe-8b26-5912d8ceb778", "c9c5cf61-fa8c-48bd-8a0d-7f96984fcffa" }
                });
        }
    }
}
