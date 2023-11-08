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
    [Migration("20220519224917_AgregandoCampoUsuario")]
    partial class AgregandoCampoUsuario
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
                    b.Property<string>("ARTICULO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DESCRIPCION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROVEEDOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TIPO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ARTICULO");

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

                    b.Property<decimal>("Conteo10")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo11")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo12")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo13")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo14")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo15")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo5")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo6")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo7")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo8")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Conteo9")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Host1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Um")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User9")
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
