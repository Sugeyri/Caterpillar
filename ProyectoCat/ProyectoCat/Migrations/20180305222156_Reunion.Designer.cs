﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProyectoCat.Models;
using System;

namespace ProyectoCat.Migrations
{
    [DbContext(typeof(ProyectoCatContext))]
    [Migration("20180305222156_Reunion")]
    partial class Reunion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CédulaJurídica")
                        .IsRequired();

                    b.Property<string>("DirecciónFísica")
                        .IsRequired();

                    b.Property<int>("IdSector");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("PáginaWeb")
                        .IsRequired();

                    b.Property<int?>("SectorID");

                    b.HasKey("ID");

                    b.HasIndex("SectorID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProyectoCat.Models.Contactos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos")
                        .IsRequired();

                    b.Property<int?>("ClienteID");

                    b.Property<string>("CorreoElectrónico")
                        .IsRequired();

                    b.Property<int>("IdCliente");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Puesto")
                        .IsRequired();

                    b.Property<string>("Teléfono")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Contactos");
                });

            modelBuilder.Entity("ProyectoCat.Models.EstadoTicket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("EstadoTicket");
                });

            modelBuilder.Entity("ProyectoCat.Models.Reunion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DíaYHora");

                    b.Property<string>("Título")
                        .IsRequired();

                    b.Property<int>("UsuarioId");

                    b.Property<bool>("Virtual");

                    b.HasKey("ID");

                    b.HasIndex("ClienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Reunion");
                });

            modelBuilder.Entity("ProyectoCat.Models.Sector", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("ProyectoCat.Models.Tickets", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("Detalle")
                        .IsRequired();

                    b.Property<int>("EstadoId");

                    b.Property<string>("Reporta")
                        .IsRequired();

                    b.Property<string>("Título")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ProyectoCat.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Administrador");

                    b.Property<string>("Ccontrasenna")
                        .IsRequired();

                    b.Property<string>("Contrasenna")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("NombreUsuario")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Cliente", b =>
                {
                    b.HasOne("ProyectoCat.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorID");
                });

            modelBuilder.Entity("ProyectoCat.Models.Contactos", b =>
                {
                    b.HasOne("Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });

            modelBuilder.Entity("ProyectoCat.Models.Reunion", b =>
                {
                    b.HasOne("Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoCat.Models.Usuario", "UsuarioAsignado")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoCat.Models.Tickets", b =>
                {
                    b.HasOne("Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoCat.Models.EstadoTicket", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
