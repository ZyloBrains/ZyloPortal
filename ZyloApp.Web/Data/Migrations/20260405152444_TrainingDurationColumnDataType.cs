using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TrainingDurationColumnDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationHours",
                table: "Training");

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Training",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Training");

            migrationBuilder.AddColumn<float>(
                name: "DurationHours",
                table: "Training",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
