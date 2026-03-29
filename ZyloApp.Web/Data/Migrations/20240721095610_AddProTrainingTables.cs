using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProTrainingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseQuotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerUnit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseQuotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseQuoteModules",
                columns: table => new
                {
                    CourseQuoteId = table.Column<int>(type: "int", nullable: false),
                    ModulesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseQuoteModules", x => new { x.CourseQuoteId, x.ModulesId });
                    table.ForeignKey(
                        name: "FK_CourseQuoteModules_CourseQuotes_CourseQuoteId",
                        column: x => x.CourseQuoteId,
                        principalTable: "CourseQuotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseQuoteModules_Widgets_ModulesId",
                        column: x => x.ModulesId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DurationHours = table.Column<float>(type: "real", nullable: false),
                    DiscountPercentage = table.Column<float>(type: "real", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    CourseQuoteId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_CourseQuotes_CourseQuoteId",
                        column: x => x.CourseQuoteId,
                        principalTable: "CourseQuotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Students_TrainingId",
                table: "Students",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseQuoteModules_ModulesId",
                table: "CourseQuoteModules",
                column: "ModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_CourseQuoteId",
                table: "Training",
                column: "CourseQuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_InstructorId",
                table: "Training",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_OrganizationId",
                table: "Training",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Training_TrainingId",
                table: "Students",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Training_TrainingId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "CourseQuoteModules");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "CourseQuotes");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_Students_TrainingId",
                table: "Students");

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

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Students");

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
        }
    }
}
