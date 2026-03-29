using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSiteSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteSections");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Sections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Sections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SiteId",
                table: "Sections",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_SiteId",
                table: "Sections",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Sites_SiteId",
                table: "Sections",
                column: "SiteId",
                principalTable: "Sites",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Sites_SiteId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_SiteId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "Sections");

            migrationBuilder.CreateTable(
                name: "SiteSections",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    SiteId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_SiteSections_SiteId",
                table: "SiteSections",
                column: "SiteId");
        }
    }
}
