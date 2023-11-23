﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetCafes.Data;

#nullable disable

namespace PetCafes.Migrations
{
    [DbContext(typeof(PetCafeDbContext))]
    [Migration("20231122225155_VendaMaisProduto5")]
    partial class VendaMaisProduto5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("PetCafes.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Cpf");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PetCafes.Models.Produto", b =>
                {
                    b.Property<int?>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Codigo");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("PetCafes.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteCPF")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProdutoCodigo")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("ValorVenda")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ClienteCPF");

                    b.HasIndex("ProdutoCodigo");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("PetCafes.Models.Venda", b =>
                {
                    b.HasOne("PetCafes.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteCPF");

                    b.HasOne("PetCafes.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoCodigo");

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}