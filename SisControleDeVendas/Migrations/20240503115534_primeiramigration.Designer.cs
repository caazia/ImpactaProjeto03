﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SisControleDeVendas.Data;

#nullable disable

namespace SisControleDeVendas.Migrations
{
    [DbContext(typeof(SisControleDeVendasContext))]
    [Migration("20240503115534_primeiramigration")]
    partial class primeiramigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SisControleDeVendas.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<string>("CEP")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtCad")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NivelDeAcesso")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SisControleDeVendas.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuncionarioID"));

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DtAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NivelDeAcesso")
                        .HasColumnType("int");

                    b.Property<string>("NomeFunc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Senha")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuncionarioID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("SisControleDeVendas.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoID"));

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornecedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ProdutoID");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SisControleDeVendas.Models.Venda", b =>
                {
                    b.Property<int>("VendaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendaID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuncionarioID")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFunc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProdutoID")
                        .HasColumnType("int");

                    b.HasKey("VendaID");

                    b.ToTable("Venda");
                });
#pragma warning restore 612, 618
        }
    }
}
