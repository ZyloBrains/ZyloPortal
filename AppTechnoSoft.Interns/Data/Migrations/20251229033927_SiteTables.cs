using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SiteTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TechPrograms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sites",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionWidgets",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    WidgetId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionWidgets", x => new { x.SectionId, x.WidgetId });
                    table.ForeignKey(
                        name: "FK_SectionWidgets_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SectionWidgets_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteSections",
                columns: table => new
                {
                    SiteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSections", x => new { x.SectionId, x.SiteId });
                    table.ForeignKey(
                        name: "FK_SiteSections_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteSections_Sites_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Sites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SectionWidgets_WidgetId",
                table: "SectionWidgets",
                column: "WidgetId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSections_SiteId",
                table: "SiteSections",
                column: "SiteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SectionWidgets");

            migrationBuilder.DropTable(
                name: "SiteSections");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Location", "Name" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Bhadrapur, Jhapa", "Mechi Multiple Campus" },
                    { 2, null, null, null, null, "Dhankuta", "Dhankuta Multiple Campus" },
                    { 3, null, null, null, null, "Dharan", "Central Campus of Technology" },
                    { 4, null, null, null, null, "Biratnagar", "Mahendra Morang Adarsha Multiple Campus" },
                    { 5, null, null, null, null, "Rajbiraj", "Mahendra Bindeshwori Multiple Campus" },
                    { 6, null, null, null, null, "Siraha", "Surya Narayan Satya Na. Mo. Yadav Campus" },
                    { 7, null, null, null, null, "Janakpur", "Ramsorup Ramsagar Multiple Campus" },
                    { 8, null, null, null, null, "Birgunj", "Thakur Ram Multiple Campus" },
                    { 9, null, null, null, null, "Bharatpur", "Birendra Multiple Campus" },
                    { 10, null, null, null, null, "Pokhara", "Prithivi Narayan Multiple Campus" },
                    { 11, null, null, null, null, "Mahendranagar", "SidhaNath Science Campus" },
                    { 12, null, null, null, null, "Nepalgunj", "Mahendra Multiple Campus" },
                    { 13, null, null, null, null, "Butwal", "Butwal Multiple Campus" },
                    { 19, null, null, null, null, "Bagbazar", "Padma Kanya Multiple Campus" },
                    { 20, null, null, null, null, "Ghorahi, Dang", "Mahendra Multiple Campus" },
                    { 21, null, null, null, null, "Baglung", "Dhaulagiri Campus" },
                    { 22, null, null, null, null, "Gorkha", "Gorkha Campus" },
                    { 23, null, null, null, null, "Bhairahawa", "Bhairahawa Multiple Campus" },
                    { 24, null, null, null, null, "Biratnagar", "Degree Campus" }
                });

            migrationBuilder.InsertData(
                table: "TechPrograms",
                columns: new[] { "Id", "Affliation", "Created", "CreatedBy", "LastUpdated", "LastUpdatedBy", "Name" },
                values: new object[,]
                {
                    { 1, "TU", null, null, null, null, "BCA" },
                    { 2, "PU", null, null, null, null, "BCA" },
                    { 3, "TU", null, null, null, null, "BIT" },
                    { 4, "PU", null, null, null, null, "BIT" },
                    { 5, "TU", null, null, null, null, "BIM" },
                    { 6, "TU", null, null, null, null, "BScIT" },
                    { 7, "PU", null, null, null, null, "BScIT" }
                });
        }
    }
}
