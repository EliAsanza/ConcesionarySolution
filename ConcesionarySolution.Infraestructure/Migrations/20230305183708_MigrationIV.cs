using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcesionarySolution.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class MigrationIV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tuition",
                table: "cars",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "LicensePlate",
                table: "cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicensePlate",
                table: "cars");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "cars",
                newName: "Tuition");
        }
    }
}
