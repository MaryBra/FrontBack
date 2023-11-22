﻿// <auto-generated />
using System;
using LojaDeJogos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaDeJogos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231010002714_CriacaoInicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Carrinho", b =>
                {
                    b.Property<int>("IdCarrinho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("IdCarrinho");

                    b.ToTable("Carrinho");
                });

            modelBuilder.Entity("Classificacao", b =>
                {
                    b.Property<int>("IdClassificacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("IdClassificacao");

                    b.ToTable("Classificacao");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Endereco")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("TEXT");

                    b.Property<long>("Telefone")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Desenvolvedor", b =>
                {
                    b.Property<int>("IdDesenvolvedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Historico")
                        .HasColumnType("TEXT");

                    b.Property<string>("JogosProduzidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeDesenvolvedor")
                        .HasColumnType("TEXT");

                    b.HasKey("IdDesenvolvedor");

                    b.ToTable("Desenvolvedor");
                });

            modelBuilder.Entity("Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPagamento");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarrinhoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("TEXT");

                    b.Property<int>("PagamentoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdPedido");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CarrinhoIdCarrinho")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Classificacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Desenvolvedor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estoque")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstoqueId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Plataforma")
                        .HasColumnType("TEXT");

                    b.Property<float>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("IdProduto");

                    b.HasIndex("CarrinhoIdCarrinho");

                    b.HasIndex("EstoqueId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Pedido", b =>
                {
                    b.HasOne("Carrinho", "Carrinho")
                        .WithMany()
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrinho");

                    b.Navigation("Cliente");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Produto", b =>
                {
                    b.HasOne("Carrinho", null)
                        .WithMany("ItensCarrinho")
                        .HasForeignKey("CarrinhoIdCarrinho");

                    b.HasOne("Estoque", null)
                        .WithMany("Produtos")
                        .HasForeignKey("EstoqueId");
                });

            modelBuilder.Entity("Carrinho", b =>
                {
                    b.Navigation("ItensCarrinho");
                });

            modelBuilder.Entity("Estoque", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
