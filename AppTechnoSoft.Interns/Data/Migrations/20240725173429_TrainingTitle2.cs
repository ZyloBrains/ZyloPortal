using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainingTitle2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Label",
                table: "Training",
                newName: "Title");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ad8d025-56da-49ce-8ada-3bf97ed433de", "1ad8d025-56da-49ce-8ada-3bf97ed433de", "Admin", "ADMIN" },
                    { "b6177807-55ae-4a45-8731-de5626872d78", "b6177807-55ae-4a45-8731-de5626872d78", "SuperAdmin", "SUPERADMIN" },
                    { "c7e241a4-4305-4aca-9e12-6a7334d202a2", "c7e241a4-4305-4aca-9e12-6a7334d202a2", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a023dd75-3a54-4878-8cc9-a59b851cb393", 0, "dea114b0-92a3-40f3-b599-1719fcacd30d", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAELFtPVjllB9VVJNIm9imKiQ46QeMqkl9wVSWbRJPR55h9YUbW2zY4q3TJ/sqBR8PNg==", null, false, "78150947-1952-486b-a3b9-f9e2670687e2", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 7, 25, 23, 19, 28, 259, DateTimeKind.Local).AddTicks(4168));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1ad8d025-56da-49ce-8ada-3bf97ed433de", "a023dd75-3a54-4878-8cc9-a59b851cb393" },
                    { "b6177807-55ae-4a45-8731-de5626872d78", "a023dd75-3a54-4878-8cc9-a59b851cb393" },
                    { "c7e241a4-4305-4aca-9e12-6a7334d202a2", "a023dd75-3a54-4878-8cc9-a59b851cb393" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1ad8d025-56da-49ce-8ada-3bf97ed433de", "a023dd75-3a54-4878-8cc9-a59b851cb393" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6177807-55ae-4a45-8731-de5626872d78", "a023dd75-3a54-4878-8cc9-a59b851cb393" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7e241a4-4305-4aca-9e12-6a7334d202a2", "a023dd75-3a54-4878-8cc9-a59b851cb393" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1ad8d025-56da-49ce-8ada-3bf97ed433de");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b6177807-55ae-4a45-8731-de5626872d78");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c7e241a4-4305-4aca-9e12-6a7334d202a2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "a023dd75-3a54-4878-8cc9-a59b851cb393");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Training",
                newName: "Label");

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
    }
}
