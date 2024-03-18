﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoBanco.Data;

#nullable disable

namespace ProjetoBanco.Migrations
{
    [DbContext(typeof(IESContext))]
    [Migration("20240314224636_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoBanco.Models.Banco", b =>
                {
                    b.Property<int>("BancoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BancoID"));

                    b.Property<string>("CD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroConta")
                        .HasColumnType("int");

                    b.Property<int>("Saldo")
                        .HasColumnType("int");

                    b.Property<long>("fk_ClienteID")
                        .HasColumnType("bigint");

                    b.HasKey("BancoID");

                    b.HasIndex("fk_ClienteID");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("ProjetoBanco.Models.Cliente", b =>
                {
                    b.Property<long?>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("ClienteID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjetoBanco.Models.Banco", b =>
                {
                    b.HasOne("ProjetoBanco.Models.Cliente", "Cliente")
                        .WithMany("Bancos")
                        .HasForeignKey("fk_ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ProjetoBanco.Models.Cliente", b =>
                {
                    b.Navigation("Bancos");
                });
#pragma warning restore 612, 618
        }
    }
}