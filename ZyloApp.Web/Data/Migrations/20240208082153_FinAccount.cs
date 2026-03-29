using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_FinAccounts_FinAccountId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FinAccountId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "32fd450f-ab5e-4b63-a7dc-38f5e30e502c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9fa4ba00-c6a1-487b-a6c4-f56fb276bd67");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "08e4ff02-9df1-415c-ab49-892c539a689b" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3d7bc476-9cdd-4eb8-899f-2c313ec71e73");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "08e4ff02-9df1-415c-ab49-892c539a689b");

            migrationBuilder.DropColumn(
                name: "FinAccountId",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "FinAccounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: null);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52a1c35a-e1c5-4466-8879-953a975a3bb1", "52a1c35a-e1c5-4466-8879-953a975a3bb1", "Admin", "ADMIN" },
                    { "86b30e13-0c78-4436-b297-3993f840ba12", "86b30e13-0c78-4436-b297-3993f840ba12", "Trainee", "TRAINEE" },
                    { "999556a0-4c04-45ad-84cc-811814e7a580", "999556a0-4c04-45ad-84cc-811814e7a580", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: null);

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: null);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21e10d3e-51e3-4f5f-ab21-7249ea386de9", 0, "42bba37d-b489-40d0-a28d-a590ceac5775", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEHqHch1v92ttjXAvWaX/EKEe6Rs/QFwTfG98yL/JwQLRfYf5jPWxxBGzcA8lyWXeqw==", null, false, "93b7aca7-b0e5-4b3f-a2dc-7823632cd996", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 8, 14, 6, 52, 588, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "999556a0-4c04-45ad-84cc-811814e7a580", "21e10d3e-51e3-4f5f-ab21-7249ea386de9" });

            migrationBuilder.CreateIndex(
                name: "IX_FinAccounts_StudentId",
                table: "FinAccounts",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FinAccounts_Students_StudentId",
                table: "FinAccounts",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinAccounts_Students_StudentId",
                table: "FinAccounts");

            migrationBuilder.DropIndex(
                name: "IX_FinAccounts_StudentId",
                table: "FinAccounts");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "52a1c35a-e1c5-4466-8879-953a975a3bb1");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "86b30e13-0c78-4436-b297-3993f840ba12");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "999556a0-4c04-45ad-84cc-811814e7a580", "21e10d3e-51e3-4f5f-ab21-7249ea386de9" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "999556a0-4c04-45ad-84cc-811814e7a580");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21e10d3e-51e3-4f5f-ab21-7249ea386de9");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "FinAccounts");

            migrationBuilder.AddColumn<int>(
                name: "FinAccountId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32fd450f-ab5e-4b63-a7dc-38f5e30e502c", "32fd450f-ab5e-4b63-a7dc-38f5e30e502c", "Trainee", "TRAINEE" },
                    { "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "SuperAdmin", "SUPERADMIN" },
                    { "9fa4ba00-c6a1-487b-a6c4-f56fb276bd67", "9fa4ba00-c6a1-487b-a6c4-f56fb276bd67", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "08e4ff02-9df1-415c-ab49-892c539a689b", 0, "4d6c5e2a-3981-4764-af81-07e4e6b1d0f6", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEMXZQToP7v66Y+cWWQGENKbKu2mcOvH4kemxkuFg97K4ms2RfWmrqOtgi2lYFxgkTQ==", null, false, "09e416de-8a5d-46a4-aa2b-1b79bed5c8db", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 2, 6, 20, 4, 26, 224, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d7bc476-9cdd-4eb8-899f-2c313ec71e73", "08e4ff02-9df1-415c-ab49-892c539a689b" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_FinAccountId",
                table: "Students",
                column: "FinAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_FinAccounts_FinAccountId",
                table: "Students",
                column: "FinAccountId",
                principalTable: "FinAccounts",
                principalColumn: "Id");
        }
    }
}
