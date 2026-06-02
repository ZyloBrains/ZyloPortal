using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class RevenueAndProjectChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpentBudget",
                table: "Projects",
                newName: "AmcCost");

            migrationBuilder.RenameColumn(
                name: "AllocatedBudget",
                table: "Projects",
                newName: "InitialCost");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Revenues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Revenues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Revenues_ProjectId",
                table: "Revenues",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Revenues_Projects_ProjectId",
                table: "Revenues",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Revenues_Projects_ProjectId",
                table: "Revenues");

            migrationBuilder.DropIndex(
                name: "IX_Revenues_ProjectId",
                table: "Revenues");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Revenues");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Revenues");

            migrationBuilder.RenameColumn(
                name: "InitialCost",
                table: "Projects",
                newName: "AllocatedBudget");

            migrationBuilder.RenameColumn(
                name: "AmcCost",
                table: "Projects",
                newName: "SpentBudget");
        }
    }
}
