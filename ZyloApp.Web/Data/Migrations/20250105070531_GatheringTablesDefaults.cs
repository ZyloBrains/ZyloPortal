using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class GatheringTablesDefaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GatheringCalendars_Gatherings_WorkshopId",
                table: "GatheringCalendars");

            migrationBuilder.RenameColumn(
                name: "WorkshopId",
                table: "GatheringCalendars",
                newName: "GatheringId");

            migrationBuilder.RenameIndex(
                name: "IX_GatheringCalendars_WorkshopId",
                table: "GatheringCalendars",
                newName: "IX_GatheringCalendars_GatheringId");

            migrationBuilder.AddForeignKey(
                name: "FK_GatheringCalendars_Gatherings_GatheringId",
                table: "GatheringCalendars",
                column: "GatheringId",
                principalTable: "Gatherings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GatheringCalendars_Gatherings_GatheringId",
                table: "GatheringCalendars");

            migrationBuilder.RenameColumn(
                name: "GatheringId",
                table: "GatheringCalendars",
                newName: "WorkshopId");

            migrationBuilder.RenameIndex(
                name: "IX_GatheringCalendars_GatheringId",
                table: "GatheringCalendars",
                newName: "IX_GatheringCalendars_WorkshopId");

            migrationBuilder.AddForeignKey(
                name: "FK_GatheringCalendars_Gatherings_WorkshopId",
                table: "GatheringCalendars",
                column: "WorkshopId",
                principalTable: "Gatherings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
