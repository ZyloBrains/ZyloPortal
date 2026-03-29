using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class GatheringTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 18);

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
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Widgets",
                keyColumn: "Id",
                keyValue: 7);

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

            migrationBuilder.CreateTable(
                name: "Gatherings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agenda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quote = table.Column<float>(type: "real", nullable: false),
                    QuotePerAttendee = table.Column<bool>(type: "bit", nullable: false),
                    MaxAttendees = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gatherings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatheringCalendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurationHoursPerDay = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkshopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatheringCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GatheringCalendars_Gatherings_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Gatherings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GatheringCalendars_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GatheringCalendarInstructor",
                columns: table => new
                {
                    ConsultantsId = table.Column<int>(type: "int", nullable: false),
                    GatheringCalendarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatheringCalendarInstructor", x => new { x.ConsultantsId, x.GatheringCalendarId });
                    table.ForeignKey(
                        name: "FK_GatheringCalendarInstructor_GatheringCalendars_GatheringCalendarId",
                        column: x => x.GatheringCalendarId,
                        principalTable: "GatheringCalendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GatheringCalendarInstructor_Instructors_ConsultantsId",
                        column: x => x.ConsultantsId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GatheringCalendarInstructor_GatheringCalendarId",
                table: "GatheringCalendarInstructor",
                column: "GatheringCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_GatheringCalendars_OrganizationId",
                table: "GatheringCalendars",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_GatheringCalendars_WorkshopId",
                table: "GatheringCalendars",
                column: "WorkshopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GatheringCalendarInstructor");

            migrationBuilder.DropTable(
                name: "GatheringCalendars");

            migrationBuilder.DropTable(
                name: "Gatherings");

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Location", "Name" },
                values: new object[,]
                {
                    { 14, null, null, null, null, "Palpa", "Tribhuvan Multiple Campus" },
                    { 15, null, null, null, null, "Ghantaghar", "Tri-Chandra Multiple Campus" },
                    { 16, null, null, null, null, "Lainchour", "Amrit Science Campus" },
                    { 17, null, null, null, null, "Patan", "Patan Multiple Campus" },
                    { 18, null, null, null, null, "Bhaktapur", "Bhaktapur Multiple Campus" }
                });

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

            migrationBuilder.InsertData(
                table: "Widgets",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "HtmlContent", "LastUpdated", "LastUpdatedBy", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3372), "Seed", "An display item in home page", "Welcome to AppTechnoSoft! An initiative for students and freshers.", null, null, "CarouselItem" },
                    { 2, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3385), "Seed", "An display item in home page", "Bridging the gap between academia and industry!", null, null, "CarouselItem" },
                    { 3, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3387), "Seed", "An display item in home page", "We guide you on software R&D and SDLC to kickstart your career!", null, null, "CarouselItem" },
                    { 4, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3389), "Seed", "An display item in home page", "Replacement Opportunities!", null, null, "CarouselItem" },
                    { 5, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3391), "Seed", "An display item in home page", "From basics to professional touches!", null, null, "CarouselItem" },
                    { 6, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3394), "Seed", "GIT and GitHub Essentials", "todo", null, null, "Module" },
                    { 7, new DateTime(2024, 8, 27, 14, 49, 22, 527, DateTimeKind.Local).AddTicks(3396), "Seed", "Training + Internship Combo", "todo", null, null, "HomeIntro" }
                });

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
    }
}
