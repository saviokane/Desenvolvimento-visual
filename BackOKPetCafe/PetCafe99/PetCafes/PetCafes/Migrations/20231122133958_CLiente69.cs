using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCafes.Migrations
{
    /// <inheritdoc />
    public partial class CLiente69 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Cliente",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "Idade");
        }
    }
}
