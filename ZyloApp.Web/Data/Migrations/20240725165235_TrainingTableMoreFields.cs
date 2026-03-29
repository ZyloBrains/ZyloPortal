using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainingTableMoreFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50c2634d-5c7a-45cb-8216-1941dbac1961", "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6dcc6dc1-6640-4aca-b2f7-1f7e5f1aae9a", "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bde7b3a5-48a6-404a-a4ef-e04a3fa6271c", "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "50c2634d-5c7a-45cb-8216-1941dbac1961");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6dcc6dc1-6640-4aca-b2f7-1f7e5f1aae9a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bde7b3a5-48a6-404a-a4ef-e04a3fa6271c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63");

            migrationBuilder.AddColumn<string>(
                name: "Hash",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Training",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Batches",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8427da88-289d-4776-b900-596c1222712c", "8427da88-289d-4776-b900-596c1222712c", "Trainee", "TRAINEE" },
                    { "e985095f-6648-45e6-81ae-f5369d23e0ff", "e985095f-6648-45e6-81ae-f5369d23e0ff", "SuperAdmin", "SUPERADMIN" },
                    { "fc068968-7bab-451e-bad0-1eb06c8efce0", "fc068968-7bab-451e-bad0-1eb06c8efce0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4d9eb32a-417f-4d1a-ad5a-fb7564094155", 0, "dadd4e03-a7d4-44f7-b0d7-f1f0745c525e", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEKnca+qZ/fjzvUHh9GcQmDWOmMY2/08etIv8HD9JZ1uRIYsFGZXvgb7uC5k8cssePw==", null, false, "cb49e316-aa8a-42e0-a366-5c9ad0f2eaad", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 7, 25, 22, 37, 31, 773, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8427da88-289d-4776-b900-596c1222712c", "4d9eb32a-417f-4d1a-ad5a-fb7564094155" },
                    { "e985095f-6648-45e6-81ae-f5369d23e0ff", "4d9eb32a-417f-4d1a-ad5a-fb7564094155" },
                    { "fc068968-7bab-451e-bad0-1eb06c8efce0", "4d9eb32a-417f-4d1a-ad5a-fb7564094155" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_TrainingId",
                table: "Batches",
                column: "TrainingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Training_TrainingId",
                table: "Batches",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Training_TrainingId",
                table: "Batches");

            migrationBuilder.DropIndex(
                name: "IX_Batches_TrainingId",
                table: "Batches");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8427da88-289d-4776-b900-596c1222712c", "4d9eb32a-417f-4d1a-ad5a-fb7564094155" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e985095f-6648-45e6-81ae-f5369d23e0ff", "4d9eb32a-417f-4d1a-ad5a-fb7564094155" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc068968-7bab-451e-bad0-1eb06c8efce0", "4d9eb32a-417f-4d1a-ad5a-fb7564094155" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8427da88-289d-4776-b900-596c1222712c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e985095f-6648-45e6-81ae-f5369d23e0ff");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fc068968-7bab-451e-bad0-1eb06c8efce0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4d9eb32a-417f-4d1a-ad5a-fb7564094155");

            migrationBuilder.DropColumn(
                name: "Hash",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Batches");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50c2634d-5c7a-45cb-8216-1941dbac1961", "50c2634d-5c7a-45cb-8216-1941dbac1961", "Trainee", "TRAINEE" },
                    { "6dcc6dc1-6640-4aca-b2f7-1f7e5f1aae9a", "6dcc6dc1-6640-4aca-b2f7-1f7e5f1aae9a", "SuperAdmin", "SUPERADMIN" },
                    { "bde7b3a5-48a6-404a-a4ef-e04a3fa6271c", "bde7b3a5-48a6-404a-a4ef-e04a3fa6271c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63", 0, "2973b5f4-0e0c-4ead-a198-ae13f0ab6048", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEFV+ZMrLWzvBflfY16pNWfrZVVc+S1EbSR40jRZzQsxX3OHdrKpbNdw09fYZpzTEyg==", null, false, "8b9bc078-9ac0-47df-aaca-d6b9e140775e", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 7, 21, 15, 41, 9, 360, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "50c2634d-5c7a-45cb-8216-1941dbac1961", "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63" },
                    { "6dcc6dc1-6640-4aca-b2f7-1f7e5f1aae9a", "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63" },
                    { "bde7b3a5-48a6-404a-a4ef-e04a3fa6271c", "90dc1c96-8b8e-458a-b0f4-4810c5d7ed63" }
                });
        }
    }
}
