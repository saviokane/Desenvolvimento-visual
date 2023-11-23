using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using PetCafes.Data;
using PetCafes.Models;

#nullable disable

namespace PetCafes.Migrations
{
    [DbContext(typeof(PetCafeDbContext))]
    [Migration("20231122133303_inicial")]
    partial class Alteracao : Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");
 modelBuilder.Entity<Venda>()
        .Property(v => v.Produto)
        .HasConversion<string>();
            modelBuilder.Entity("PetCafeProject.Models.Cliente", b =>
                {
                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("cpf");

                    b.ToTable("Cliente");
                });

                 modelBuilder.Entity("PetCafeProject.Models.Produto", b =>
                {
                    b.Property<int?>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Codigo");

                    b.ToTable("Produto");
                });

                 modelBuilder.Entity("PetCafeProject.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteCPF")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProdutoCodigo")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Quant")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("ValorVenda")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClienteCPF");

                    b.HasIndex("ProdutoCodigo");

                    b.ToTable("Venda");
                });


#pragma warning restore 612, 618
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
