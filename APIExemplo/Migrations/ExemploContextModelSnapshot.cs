﻿// <auto-generated />
using APIExemplo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIExemplo.Migrations
{
    [DbContext(typeof(ExemploContext))]
    partial class ExemploContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIExemplo.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("anoVencimento")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("fabricante")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("lote")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("mesVencimento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });
#pragma warning restore 612, 618
        }
    }
}