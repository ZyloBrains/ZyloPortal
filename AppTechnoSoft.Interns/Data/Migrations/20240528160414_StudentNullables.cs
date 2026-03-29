using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class StudentNullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_TechPrograms_TechProgramId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a590499-6c8b-4962-ab5b-517a3a1af452", "1f95d999-700e-424b-9dc8-e876f3589f99" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "224643d1-dd33-4069-916d-c3fcbeea4ad3", "1f95d999-700e-424b-9dc8-e876f3589f99" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc566747-f92d-4db9-b251-4c4659f167f0", "1f95d999-700e-424b-9dc8-e876f3589f99" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0a590499-6c8b-4962-ab5b-517a3a1af452");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "224643d1-dd33-4069-916d-c3fcbeea4ad3");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fc566747-f92d-4db9-b251-4c4659f167f0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1f95d999-700e-424b-9dc8-e876f3589f99");

            migrationBuilder.AlterColumn<int>(
                name: "TechProgramId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d092d67-be01-49e9-a8e1-f2a8977ae592", "6d092d67-be01-49e9-a8e1-f2a8977ae592", "SuperAdmin", "SUPERADMIN" },
                    { "8453e6fc-6c42-470e-a602-f3263b60ac30", "8453e6fc-6c42-470e-a602-f3263b60ac30", "Trainee", "TRAINEE" },
                    { "c9998673-0fd7-4ead-ab18-b0ea8a22999c", "c9998673-0fd7-4ead-ab18-b0ea8a22999c", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d5d1c1bc-b50f-4835-998d-04fd98833154", 0, "e2010785-619f-4edb-a5b4-fa6db2850812", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAED5lBz8Dgt3AdLyMC0N0uzUWPxB5vN1AKeF/HXKTIgHE5sOACP0gbRMj+2x2RXDOYA==", null, false, "c11a13df-e734-41c2-9ef8-5d52026d4851", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 28, 21, 49, 11, 347, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6d092d67-be01-49e9-a8e1-f2a8977ae592", "d5d1c1bc-b50f-4835-998d-04fd98833154" },
                    { "8453e6fc-6c42-470e-a602-f3263b60ac30", "d5d1c1bc-b50f-4835-998d-04fd98833154" },
                    { "c9998673-0fd7-4ead-ab18-b0ea8a22999c", "d5d1c1bc-b50f-4835-998d-04fd98833154" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_TechPrograms_TechProgramId",
                table: "Students",
                column: "TechProgramId",
                principalTable: "TechPrograms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_TechPrograms_TechProgramId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d092d67-be01-49e9-a8e1-f2a8977ae592", "d5d1c1bc-b50f-4835-998d-04fd98833154" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8453e6fc-6c42-470e-a602-f3263b60ac30", "d5d1c1bc-b50f-4835-998d-04fd98833154" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9998673-0fd7-4ead-ab18-b0ea8a22999c", "d5d1c1bc-b50f-4835-998d-04fd98833154" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "6d092d67-be01-49e9-a8e1-f2a8977ae592");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8453e6fc-6c42-470e-a602-f3263b60ac30");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c9998673-0fd7-4ead-ab18-b0ea8a22999c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "d5d1c1bc-b50f-4835-998d-04fd98833154");

            migrationBuilder.AlterColumn<int>(
                name: "TechProgramId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CollegeId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a590499-6c8b-4962-ab5b-517a3a1af452", "0a590499-6c8b-4962-ab5b-517a3a1af452", "Admin", "ADMIN" },
                    { "224643d1-dd33-4069-916d-c3fcbeea4ad3", "224643d1-dd33-4069-916d-c3fcbeea4ad3", "Trainee", "TRAINEE" },
                    { "fc566747-f92d-4db9-b251-4c4659f167f0", "fc566747-f92d-4db9-b251-4c4659f167f0", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1f95d999-700e-424b-9dc8-e876f3589f99", 0, "50c8cf1d-83a1-47b4-bc00-d7790da7274a", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEAuAldh2xQEakXAlsmyUm/mrOVbXv6tHIQf82LsDw/vlZL47Ee0TXWwV357CWaNtwQ==", null, false, "9fe524ff-060b-449a-b122-570d15a68828", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 5, 28, 15, 43, 10, 518, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0a590499-6c8b-4962-ab5b-517a3a1af452", "1f95d999-700e-424b-9dc8-e876f3589f99" },
                    { "224643d1-dd33-4069-916d-c3fcbeea4ad3", "1f95d999-700e-424b-9dc8-e876f3589f99" },
                    { "fc566747-f92d-4db9-b251-4c4659f167f0", "1f95d999-700e-424b-9dc8-e876f3589f99" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Colleges_CollegeId",
                table: "Students",
                column: "CollegeId",
                principalTable: "Colleges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_TechPrograms_TechProgramId",
                table: "Students",
                column: "TechProgramId",
                principalTable: "TechPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
