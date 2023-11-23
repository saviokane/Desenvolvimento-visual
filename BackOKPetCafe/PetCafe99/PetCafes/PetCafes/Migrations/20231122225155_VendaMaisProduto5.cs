using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCafes.Migrations
{
    /// <inheritdoc />
    public partial class VendaMaisProduto5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteCpf",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "ClienteCpf",
                table: "Venda",
                newName: "ClienteCPF");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Venda",
                newName: "ValorVenda");

            migrationBuilder.RenameColumn(
                name: "Quant",
                table: "Venda",
                newName: "Quantidade");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ClienteCpf",
                table: "Venda",
                newName: "IX_Venda_ClienteCPF");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoCodigo",
                table: "Venda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ProdutoCodigo",
                table: "Venda",
                column: "ProdutoCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteCPF",
                table: "Venda",
                column: "ClienteCPF",
                principalTable: "Cliente",
                principalColumn: "Cpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Produto_ProdutoCodigo",
                table: "Venda",
                column: "ProdutoCodigo",
                principalTable: "Produto",
                principalColumn: "Codigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteCPF",
                table: "Venda");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Produto_ProdutoCodigo",
                table: "Venda");

            migrationBuilder.DropIndex(
                name: "IX_Venda_ProdutoCodigo",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ProdutoCodigo",
                table: "Venda");

            migrationBuilder.RenameColumn(
                name: "ClienteCPF",
                table: "Venda",
                newName: "ClienteCpf");

            migrationBuilder.RenameColumn(
                name: "ValorVenda",
                table: "Venda",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "Venda",
                newName: "Quant");

            migrationBuilder.RenameIndex(
                name: "IX_Venda_ClienteCPF",
                table: "Venda",
                newName: "IX_Venda_ClienteCpf");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteCpf",
                table: "Venda",
                column: "ClienteCpf",
                principalTable: "Cliente",
                principalColumn: "Cpf");
        }
    }
}
