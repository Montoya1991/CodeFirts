﻿// <auto-generated />
using System;
using Code_First.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Code_First.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Code_First.Models.Libros", b =>
                {
                    b.Property<int>("Lib_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lib_id"));

                    b.Property<string>("Lib_Autor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_Genero")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Lib_TipoProyecto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Lib_id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("Code_First.Models.Personajes", b =>
                {
                    b.Property<int>("Per_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Per_Id"));

                    b.Property<string>("Per_Apellido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Per_Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Per_FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Per_LibId")
                        .HasColumnType("int");

                    b.Property<string>("Per_LugarNacimiento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Per_Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Per_RolId")
                        .HasColumnType("int");

                    b.Property<string>("Per_Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("libroLib_id")
                        .HasColumnType("int");

                    b.HasKey("Per_Id");

                    b.HasIndex("RolId");

                    b.HasIndex("libroLib_id");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("Code_First.Models.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RolId"));

                    b.Property<string>("RolDescripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RolStatus")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Code_First.Models.Personajes", b =>
                {
                    b.HasOne("Code_First.Models.Roles", "Rol")
                        .WithMany("Personajes")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Code_First.Models.Libros", "libro")
                        .WithMany("Personajes")
                        .HasForeignKey("libroLib_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("libro");
                });

            modelBuilder.Entity("Code_First.Models.Libros", b =>
                {
                    b.Navigation("Personajes");
                });

            modelBuilder.Entity("Code_First.Models.Roles", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}