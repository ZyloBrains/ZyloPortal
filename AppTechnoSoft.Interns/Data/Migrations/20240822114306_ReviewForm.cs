using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReviewForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d44b8d-3552-49be-abca-6cfc2244cbb8", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "147db436-ae21-4013-9c9f-021fb4cc0be7", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" });

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b7e7e660-a0d0-49b5-8219-221d53b22c24", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "04d44b8d-3552-49be-abca-6cfc2244cbb8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "147db436-ae21-4013-9c9f-021fb4cc0be7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b7e7e660-a0d0-49b5-8219-221d53b22c24");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "b1f8f620-62cd-42c6-8ac3-4835d6623c37");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Reviews_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ConsultantRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    RecommendToOthers = table.Column<bool>(type: "bit", nullable: false),
                    CourseContentScore = table.Column<byte>(type: "tinyint", nullable: false),
                    TimeManagementScore = table.Column<byte>(type: "tinyint", nullable: false),
                    GuidingApproachScore = table.Column<byte>(type: "tinyint", nullable: false),
                    AssignmentsQualityScore = table.Column<byte>(type: "tinyint", nullable: false),
                    ProjectsQualityScore = table.Column<byte>(type: "tinyint", nullable: false),
                    Reviewer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewFormId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultantRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultantRatings_Reviews_ReviewFormId",
                        column: x => x.ReviewFormId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ConsultantRatings_ReviewFormId",
                table: "ConsultantRatings",
                column: "ReviewFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_InstructorId",
                table: "Reviews",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_TrainingId",
                table: "Reviews",
                column: "TrainingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultantRatings");

            migrationBuilder.DropTable(
                name: "Reviews");

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04d44b8d-3552-49be-abca-6cfc2244cbb8", "04d44b8d-3552-49be-abca-6cfc2244cbb8", "Trainee", "TRAINEE" },
                    { "147db436-ae21-4013-9c9f-021fb4cc0be7", "147db436-ae21-4013-9c9f-021fb4cc0be7", "Admin", "ADMIN" },
                    { "b7e7e660-a0d0-49b5-8219-221d53b22c24", "b7e7e660-a0d0-49b5-8219-221d53b22c24", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b1f8f620-62cd-42c6-8ac3-4835d6623c37", 0, "0a4f81bc-8c5d-4126-812e-1357ae97a343", "rawal.bishnu@live.com", true, false, null, null, "RAWAL.BISHNU@LIVE.COM", "AQAAAAIAAYagAAAAEF+wdpI6SD0+ezyr6EpZrsQ+0nM5CueORQe4vnjnMKvCO3LgI95PzILWkyP9cL0EpQ==", null, false, "daf37b0e-6c66-436b-b8a2-f5aa4e45e8c4", false, "rawal.bishnu@live.com" });

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2024, 8, 22, 17, 23, 56, 980, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "04d44b8d-3552-49be-abca-6cfc2244cbb8", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" },
                    { "147db436-ae21-4013-9c9f-021fb4cc0be7", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" },
                    { "b7e7e660-a0d0-49b5-8219-221d53b22c24", "b1f8f620-62cd-42c6-8ac3-4835d6623c37" }
                });
        }
    }
}
