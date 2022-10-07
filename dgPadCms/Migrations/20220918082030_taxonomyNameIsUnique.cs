using Microsoft.EntityFrameworkCore.Migrations;

namespace dgPadCms.Migrations
{
    public partial class taxonomyNameIsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxonomyName",
                table: "Taxonomies",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Taxonomies_TaxonomyName",
                table: "Taxonomies",
                column: "TaxonomyName",
                unique: true,
                filter: "[TaxonomyName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Taxonomies_TaxonomyName",
                table: "Taxonomies");

            migrationBuilder.AlterColumn<string>(
                name: "TaxonomyName",
                table: "Taxonomies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
