﻿// <auto-generated />
using System;
using ApiOportunidade.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiOportunidade.Migrations
{
    [DbContext(typeof(ApiOportunidadeContext))]
    partial class ApiOportunidadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Oportunidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("AprendizadoNivel")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HorasDeSono")
                        .HasColumnType("bigint");

                    b.Property<int>("HorasFolga")
                        .HasColumnType("int");

                    b.Property<int>("NivelSurto")
                        .HasColumnType("int");

                    b.Property<long>("QtdErros")
                        .HasColumnType("bigint");

                    b.Property<int>("QtdHoras")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Oportunidade");
                });
#pragma warning restore 612, 618
        }
    }
}
