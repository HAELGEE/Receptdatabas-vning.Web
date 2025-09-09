using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReceptdatabasÖvning.Web.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checkBox",
                table: "Ingredience");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "checkBox",
                table: "Ingredience",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
