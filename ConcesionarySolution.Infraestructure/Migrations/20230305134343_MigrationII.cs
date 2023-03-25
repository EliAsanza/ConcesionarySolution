using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcesionarySolution.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class MigrationII : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "cars");
        }
    }
}
