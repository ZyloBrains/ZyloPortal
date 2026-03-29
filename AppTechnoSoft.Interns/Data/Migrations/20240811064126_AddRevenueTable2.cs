using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRevenueTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8725b030-f785-4792-9acf-573d896667c0", "dc0ef707-d24c-4963-ab52-a51af2d934c9" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c55f080a-26b8-4311-b6fe-0be9b75c3035", "dc0ef707-d24c-4963-ab52-a51af2d934c9" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e311b665-c9ae-4712-9206-00f53a8f648a", "dc0ef707-d24c-4963-ab52-a51af2d934c9" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8725b030-f785-4792-9acf-573d896667c0");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c55f080a-26b8-4311-b6fe-0be9b75c3035");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e311b665-c9ae-4712-9206-00f53a8f648a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dc0ef707-d24c-4963-ab52-a51af2d934c9");

            migrationBuilder.CreateTable(
                name: "Revenues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<int>(type: "int", nullable: false),
                    Particulars = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenues", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "518b5627-6eb5-455d-ae6a-416ee7acbb53", "518b5627-6eb5-455d-ae6a-416ee7acbb53", "Trainee", "TRAINEE" },
                    { "53e396fc-733f-461b-ade0-b983a30c08af", "53e396fc-733f-461b-ade0-b983a30c08af", "SuperAdmin", "SUPERADMIN" },
                    { "c1a2a4f4-0451-4ca1-8e85-33ea005a2821", "c1a2a4f4-0451-4ca1-8e85-33ea005a2821", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "71aeaa7d-95be-4b79-9a58-46f4717c7f0c", 0, "113c1ad8-9d0a-4df4-94bf-140a9a763f96", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAENmaczPOZpVkgXC05QiZvaD2t9WezCHAwnu3X0rxaXSigjDfPAEhBSBYv8YFDK0vhQ==", null, false, "ffddc1da-5195-4349-970c-7435c338c8d4", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 26, 24, 981, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "518b5627-6eb5-455d-ae6a-416ee7acbb53", "71aeaa7d-95be-4b79-9a58-46f4717c7f0c" },
                    { "53e396fc-733f-461b-ade0-b983a30c08af", "71aeaa7d-95be-4b79-9a58-46f4717c7f0c" },
                    { "c1a2a4f4-0451-4ca1-8e85-33ea005a2821", "71aeaa7d-95be-4b79-9a58-46f4717c7f0c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Revenues");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "518b5627-6eb5-455d-ae6a-416ee7acbb53", "71aeaa7d-95be-4b79-9a58-46f4717c7f0c" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53e396fc-733f-461b-ade0-b983a30c08af", "71aeaa7d-95be-4b79-9a58-46f4717c7f0c" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1a2a4f4-0451-4ca1-8e85-33ea005a2821", "71aeaa7d-95be-4b79-9a58-46f4717c7f0c" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "518b5627-6eb5-455d-ae6a-416ee7acbb53");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "53e396fc-733f-461b-ade0-b983a30c08af");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c1a2a4f4-0451-4ca1-8e85-33ea005a2821");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "71aeaa7d-95be-4b79-9a58-46f4717c7f0c");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8725b030-f785-4792-9acf-573d896667c0", "8725b030-f785-4792-9acf-573d896667c0", "Admin", "ADMIN" },
                    { "c55f080a-26b8-4311-b6fe-0be9b75c3035", "c55f080a-26b8-4311-b6fe-0be9b75c3035", "SuperAdmin", "SUPERADMIN" },
                    { "e311b665-c9ae-4712-9206-00f53a8f648a", "e311b665-c9ae-4712-9206-00f53a8f648a", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc0ef707-d24c-4963-ab52-a51af2d934c9", 0, "6aaf8b45-11b2-47e0-875a-c70f53964546", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEHQheufST/DR0/cwJdOvX5ajLsBsuauDnd9XKu8ChIdf7+jfdYrCx35VIbfTEYkkyQ==", null, false, "111ec06b-b44b-48a5-a659-3cc5696c183a", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 11, 12, 22, 35, 113, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8725b030-f785-4792-9acf-573d896667c0", "dc0ef707-d24c-4963-ab52-a51af2d934c9" },
                    { "c55f080a-26b8-4311-b6fe-0be9b75c3035", "dc0ef707-d24c-4963-ab52-a51af2d934c9" },
                    { "e311b665-c9ae-4712-9206-00f53a8f648a", "dc0ef707-d24c-4963-ab52-a51af2d934c9" }
                });
        }
    }
}
