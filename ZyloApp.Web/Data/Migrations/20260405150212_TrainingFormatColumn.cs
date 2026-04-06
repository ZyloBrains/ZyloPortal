using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainingFormatColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Format",
                table: "Training",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Format",
                table: "Training");
        }
    }
}
