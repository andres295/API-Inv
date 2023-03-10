﻿// <auto-generated />
using System;
using ApiInv.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiInv.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220113032723_Cambiodebd")]
    partial class Cambiodebd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiInv.Entidades.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ARTICULO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("ApiInv.Entidades.Inventa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bodega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Conteo1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Host1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inventa");
                });

            modelBuilder.Entity("ApiInv.Entidades.Ubicaciones", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InventaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UBICACION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InventaId");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("ApiInv.Entidades.Ubicaciones", b =>
                {
                    b.HasOne("ApiInv.Entidades.Inventa", "Inventa")
                        .WithMany()
                        .HasForeignKey("InventaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventa");
                });
#pragma warning restore 612, 618
        }
    }
}
