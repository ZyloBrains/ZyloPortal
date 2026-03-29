using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class removedProjectsQualityScoreFromConsultantRatingsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3fd00c9c-8a77-46c7-9b25-bc324667a880", "792a7946-c15e-4776-9116-68989ed2a3d2" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5881a89c-6e0b-4d6a-b1ac-9e46d5a6f820", "792a7946-c15e-4776-9116-68989ed2a3d2" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "eb09e578-8191-469b-89e5-afad50dd66f1", "792a7946-c15e-4776-9116-68989ed2a3d2" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3fd00c9c-8a77-46c7-9b25-bc324667a880");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5881a89c-6e0b-4d6a-b1ac-9e46d5a6f820");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "eb09e578-8191-469b-89e5-afad50dd66f1");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "792a7946-c15e-4776-9116-68989ed2a3d2");

            migrationBuilder.DropColumn(
                name: "ProjectsQualityScore",
                table: "ConsultantRatings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expiration",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28011165-162d-456f-8964-d876fd1c42f5", "28011165-162d-456f-8964-d876fd1c42f5", "Admin", "ADMIN" },
                    { "331fd546-8f67-42a5-a534-f8866e1f7779", "331fd546-8f67-42a5-a534-f8866e1f7779", "SuperAdmin", "SUPERADMIN" },
                    { "7aa85389-8615-453b-93df-ef50f32c6578", "7aa85389-8615-453b-93df-ef50f32c6578", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e940745-391f-4e2c-aea4-26ee766387b5", 0, "1087851e-716e-4b12-9d9b-a7d11e89fd53", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEOpq3BMnoZNO/s8/HquKeOYzuJokyXGgzrH6kxGdGm/b9WCWNZAJYyLNXH5blAxqsQ==", null, false, "9bea8133-057d-4b6f-8651-841d68aa98e8", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28011165-162d-456f-8964-d876fd1c42f5", "2e940745-391f-4e2c-aea4-26ee766387b5" },
                    { "331fd546-8f67-42a5-a534-f8866e1f7779", "2e940745-391f-4e2c-aea4-26ee766387b5" },
                    { "7aa85389-8615-453b-93df-ef50f32c6578", "2e940745-391f-4e2c-aea4-26ee766387b5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28011165-162d-456f-8964-d876fd1c42f5", "2e940745-391f-4e2c-aea4-26ee766387b5" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "331fd546-8f67-42a5-a534-f8866e1f7779", "2e940745-391f-4e2c-aea4-26ee766387b5" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7aa85389-8615-453b-93df-ef50f32c6578", "2e940745-391f-4e2c-aea4-26ee766387b5" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "28011165-162d-456f-8964-d876fd1c42f5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "331fd546-8f67-42a5-a534-f8866e1f7779");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7aa85389-8615-453b-93df-ef50f32c6578");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2e940745-391f-4e2c-aea4-26ee766387b5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expiration",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ProjectsQualityScore",
                table: "ConsultantRatings",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fd00c9c-8a77-46c7-9b25-bc324667a880", "3fd00c9c-8a77-46c7-9b25-bc324667a880", "Admin", "ADMIN" },
                    { "5881a89c-6e0b-4d6a-b1ac-9e46d5a6f820", "5881a89c-6e0b-4d6a-b1ac-9e46d5a6f820", "SuperAdmin", "SUPERADMIN" },
                    { "eb09e578-8191-469b-89e5-afad50dd66f1", "eb09e578-8191-469b-89e5-afad50dd66f1", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "792a7946-c15e-4776-9116-68989ed2a3d2", 0, "0539bf1e-7d5d-4032-86ed-ba9a54497969", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEDfOPjVNlTNiyNpSiUo8K1XnWXJw6VtIO1RGMVcCLlA4akYQLlToZ+qxnPXNI6FGyg==", null, false, "c074dbef-61fd-46df-a92d-aeb2690de81d", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 28, 5, 140, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3fd00c9c-8a77-46c7-9b25-bc324667a880", "792a7946-c15e-4776-9116-68989ed2a3d2" },
                    { "5881a89c-6e0b-4d6a-b1ac-9e46d5a6f820", "792a7946-c15e-4776-9116-68989ed2a3d2" },
                    { "eb09e578-8191-469b-89e5-afad50dd66f1", "792a7946-c15e-4776-9116-68989ed2a3d2" }
                });
        }
    }
}
