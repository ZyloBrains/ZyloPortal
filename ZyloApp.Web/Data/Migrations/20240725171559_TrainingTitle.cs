using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainingTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Training",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d94ce9a-a404-489e-a57b-deca7e7990b4", "0d94ce9a-a404-489e-a57b-deca7e7990b4", "Admin", "ADMIN" },
                    { "78c3a0c3-3319-497c-ab23-f0331104e177", "78c3a0c3-3319-497c-ab23-f0331104e177", "SuperAdmin", "SUPERADMIN" },
                    { "dad4b864-c014-47ad-9bc8-632b41a533df", "dad4b864-c014-47ad-9bc8-632b41a533df", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "99daed04-c516-44fd-9cd1-f49c11f4d567", 0, "bb6beb50-e144-4e57-ba57-e25aea0630b5", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEHlLCf69dCZ340j91KBzzmTIm8yIg2WxcLmNuCpdl5CzzG0KU1GrjqQtNzxj1g0jnA==", null, false, "e5313a27-de58-4b03-bf50-acc2a42be8c7", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 0, 58, 494, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0d94ce9a-a404-489e-a57b-deca7e7990b4", "99daed04-c516-44fd-9cd1-f49c11f4d567" },
                    { "78c3a0c3-3319-497c-ab23-f0331104e177", "99daed04-c516-44fd-9cd1-f49c11f4d567" },
                    { "dad4b864-c014-47ad-9bc8-632b41a533df", "99daed04-c516-44fd-9cd1-f49c11f4d567" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d94ce9a-a404-489e-a57b-deca7e7990b4", "99daed04-c516-44fd-9cd1-f49c11f4d567" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78c3a0c3-3319-497c-ab23-f0331104e177", "99daed04-c516-44fd-9cd1-f49c11f4d567" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dad4b864-c014-47ad-9bc8-632b41a533df", "99daed04-c516-44fd-9cd1-f49c11f4d567" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0d94ce9a-a404-489e-a57b-deca7e7990b4");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "78c3a0c3-3319-497c-ab23-f0331104e177");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dad4b864-c014-47ad-9bc8-632b41a533df");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "99daed04-c516-44fd-9cd1-f49c11f4d567");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "Training");

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
        }
    }
}
