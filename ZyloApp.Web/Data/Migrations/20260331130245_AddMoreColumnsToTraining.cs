using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreColumnsToTraining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrainingId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TrainingId",
                table: "Tags",
                column: "TrainingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Training_TrainingId",
                table: "Tags",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Training_TrainingId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_TrainingId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Tags");
        }
    }
}
