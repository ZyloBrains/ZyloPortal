using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicantDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "ApplicantType",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainingTrack",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ApplicantType",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TrainingTrack",
                table: "Students");

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
        }
    }
}
