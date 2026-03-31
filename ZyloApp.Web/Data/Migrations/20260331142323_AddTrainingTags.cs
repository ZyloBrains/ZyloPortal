using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZyloApp.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTrainingTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Training_TrainingId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_TrainingId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "TrainingId",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "TrainingTags",
                columns: table => new
                {
                    TagsId = table.Column<int>(type: "int", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingTags", x => new { x.TagsId, x.TrainingId });
                    table.ForeignKey(
                        name: "FK_TrainingTags_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingTags_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingTags_TrainingId",
                table: "TrainingTags",
                column: "TrainingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingTags");

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
    }
}
