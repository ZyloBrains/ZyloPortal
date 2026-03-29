using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class LoanTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Principal = table.Column<float>(type: "real", nullable: false),
                    IntrestRate = table.Column<float>(type: "real", nullable: false),
                    RepaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "Admin", "ADMIN" },
                    { "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "SuperAdmin", "SUPERADMIN" },
                    { "ce568225-e52c-4bfe-827c-d94a06267d7a", "ce568225-e52c-4bfe-827c-d94a06267d7a", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2c40650-41e0-4ad1-ad78-fbecd4b58b55", 0, "338cbaad-8de9-4891-8b97-03b4af3f4e1c", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEEFoCZFhQ7gKfteSx3NVH18jKy7whsQvWj2HUOR4SYp4Cnm1TYlsTUlU0Mo7bMzL3g==", null, false, "37661d20-f051-43a9-a351-dcea642c89e3", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 18, 13, 54, 33, 920, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" },
                    { "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" },
                    { "ce568225-e52c-4bfe-827c-d94a06267d7a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5372f38f-869e-48b4-9058-cd72b7b8ec6a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce568225-e52c-4bfe-827c-d94a06267d7a", "d2c40650-41e0-4ad1-ad78-fbecd4b58b55" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3d8eaedb-5b35-4b71-b37e-53ec5dd08dcf");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5372f38f-869e-48b4-9058-cd72b7b8ec6a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ce568225-e52c-4bfe-827c-d94a06267d7a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d2c40650-41e0-4ad1-ad78-fbecd4b58b55");

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
    }
}
