﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(PushUpClayBioseguridadContext))]
    [Migration("20231211175959_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.CategoriaPersona", b =>
                {
                    b.Property<int>("IdCategoriaPer")
                        .HasColumnType("int")
                        .HasColumnName("Id_CategoriaPer");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombreCat")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdCategoriaPer")
                        .HasName("PRIMARY");

                    b.ToTable("categoriapersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("IdCiudad")
                        .HasColumnType("int")
                        .HasColumnName("Id_Ciudad");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_DepartamentoFk");

                    b.Property<string>("NombreCiudad")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("IdCiudad")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDepartamentoFk" }, "fk_Ciudad_Departamento1_idx");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("IdContactoPersona")
                        .HasColumnType("int")
                        .HasColumnName("Id_ContactoPersona");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_PersonaFk");

                    b.Property<int>("IdTipoContactoFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_TipoContactoFk");

                    b.HasKey("IdContactoPersona")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPersonaFk" }, "fk_ContactoPersona_Persona1_idx");

                    b.HasIndex(new[] { "IdTipoContactoFk" }, "fk_ContactoPersona_TipoContacto1_idx");

                    b.ToTable("contactopersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaContrato")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("FechaFin")
                        .HasColumnType("date");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_EstadoFk");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_PersonaFk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEstadoFk" }, "fk_Contrato_Estado1_idx");

                    b.HasIndex(new[] { "IdPersonaFk" }, "fk_Contrato_Persona1_idx");

                    b.ToTable("contrato", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int")
                        .HasColumnName("Id_Departamento");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_PaisFk");

                    b.Property<string>("NombreDep")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("IdDepartamento")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPaisFk" }, "fk_Departamento_Pais_idx");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DireccionPersona", b =>
                {
                    b.Property<int>("IdDirPersona")
                        .HasColumnType("int")
                        .HasColumnName("Id_DirPersona");

                    b.Property<string>("Direccion")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_PersonaFk");

                    b.Property<int>("IdTipoDireccionFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_TipoDireccionFk");

                    b.HasKey("IdDirPersona")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPersonaFk" }, "fk_DirPersona_Persona1_idx");

                    b.HasIndex(new[] { "IdTipoDireccionFk" }, "fk_DireccionPersona_TipoDireccion1_idx");

                    b.ToTable("direccionpersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("Id_Estado");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdEstado")
                        .HasName("PRIMARY");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("Id_Pais");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdPais")
                        .HasName("PRIMARY");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdCategoriaPersonaFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_CategoriaPersonaFk");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_CiudadFk");

                    b.Property<uint>("IdPersona")
                        .HasColumnType("int unsigned")
                        .HasColumnName("Id_Persona");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_TipoPersonaFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<DateOnly>("Registro")
                        .HasColumnType("date");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCategoriaPersonaFk" }, "fk_Persona_CategoriaPersona1_idx");

                    b.HasIndex(new[] { "IdCiudadFk" }, "fk_Persona_Ciudad1_idx");

                    b.HasIndex(new[] { "IdTipoPersonaFk" }, "fk_Persona_TipoPersona1_idx");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Programacion", b =>
                {
                    b.Property<int>("IdProgramacion")
                        .HasColumnType("int")
                        .HasColumnName("Id_Programacion");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdContratoFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_ContratoFk");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_PersonaFk");

                    b.Property<int>("IdTurnoFk")
                        .HasColumnType("int")
                        .HasColumnName("Id_TurnoFk");

                    b.HasKey("IdProgramacion")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdContratoFk" }, "fk_Programacion_Contrato1_idx");

                    b.HasIndex(new[] { "IdPersonaFk" }, "fk_Programacion_Persona1_idx");

                    b.HasIndex(new[] { "IdTurnoFk" }, "fk_Programacion_Turnos1_idx");

                    b.ToTable("programacion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Property<int>("IdTipoContacto")
                        .HasColumnType("int")
                        .HasColumnName("Id_TipoContacto");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdTipoContacto")
                        .HasName("PRIMARY");

                    b.ToTable("tipocontacto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoDireccion", b =>
                {
                    b.Property<int>("IdTipoDireccion")
                        .HasColumnType("int")
                        .HasColumnName("Id_TipoDireccion");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdTipoDireccion")
                        .HasName("PRIMARY");

                    b.ToTable("tipodireccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int")
                        .HasColumnName("Id_TipoPersona");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdTipoPersona")
                        .HasName("PRIMARY");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Turno", b =>
                {
                    b.Property<int>("IdTurnos")
                        .HasColumnType("int")
                        .HasColumnName("Id_Turnos");

                    b.Property<string>("HoraTurnoFin")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("horaTurnoFin");

                    b.Property<string>("HoraTurnoIng")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("horaTurnoIng");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NombreTurnos")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nombreTurnos");

                    b.HasKey("IdTurnos")
                        .HasName("PRIMARY");

                    b.ToTable("turnos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "IdDepartamentoFkNavigation")
                        .WithMany("Ciudads")
                        .HasForeignKey("IdDepartamentoFk")
                        .IsRequired()
                        .HasConstraintName("fk_Ciudad_Departamento1");

                    b.Navigation("IdDepartamentoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "IdPersonaFkNavigation")
                        .WithMany("Contactopersonas")
                        .HasForeignKey("IdPersonaFk")
                        .IsRequired()
                        .HasConstraintName("fk_ContactoPersona_Persona1");

                    b.HasOne("Domain.Entities.TipoContacto", "IdTipoContactoFkNavigation")
                        .WithMany("Contactopersonas")
                        .HasForeignKey("IdTipoContactoFk")
                        .IsRequired()
                        .HasConstraintName("fk_ContactoPersona_TipoContacto1");

                    b.Navigation("IdPersonaFkNavigation");

                    b.Navigation("IdTipoContactoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.HasOne("Domain.Entities.Estado", "IdEstadoFkNavigation")
                        .WithMany("Contratos")
                        .HasForeignKey("IdEstadoFk")
                        .IsRequired()
                        .HasConstraintName("fk_Contrato_Estado1");

                    b.HasOne("Domain.Entities.Persona", "IdPersonaFkNavigation")
                        .WithMany("Contratos")
                        .HasForeignKey("IdPersonaFk")
                        .IsRequired()
                        .HasConstraintName("fk_Contrato_Persona1");

                    b.Navigation("IdEstadoFkNavigation");

                    b.Navigation("IdPersonaFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisFkNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .IsRequired()
                        .HasConstraintName("fk_Departamento_Pais");

                    b.Navigation("IdPaisFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.DireccionPersona", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "IdPersonaFkNavigation")
                        .WithMany("Direccionpersonas")
                        .HasForeignKey("IdPersonaFk")
                        .IsRequired()
                        .HasConstraintName("fk_DirPersona_Persona1");

                    b.HasOne("Domain.Entities.TipoDireccion", "IdTipoDireccionFkNavigation")
                        .WithMany("Direccionpersonas")
                        .HasForeignKey("IdTipoDireccionFk")
                        .IsRequired()
                        .HasConstraintName("fk_DireccionPersona_TipoDireccion1");

                    b.Navigation("IdPersonaFkNavigation");

                    b.Navigation("IdTipoDireccionFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.CategoriaPersona", "IdCategoriaPersonaFkNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdCategoriaPersonaFk")
                        .IsRequired()
                        .HasConstraintName("fk_Persona_CategoriaPersona1");

                    b.HasOne("Domain.Entities.Ciudad", "IdCiudadFkNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudadFk")
                        .IsRequired()
                        .HasConstraintName("fk_Persona_Ciudad1");

                    b.HasOne("Domain.Entities.TipoPersona", "IdTipoPersonaFkNavigation")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .IsRequired()
                        .HasConstraintName("fk_Persona_TipoPersona1");

                    b.Navigation("IdCategoriaPersonaFkNavigation");

                    b.Navigation("IdCiudadFkNavigation");

                    b.Navigation("IdTipoPersonaFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Programacion", b =>
                {
                    b.HasOne("Domain.Entities.Contrato", "IdContratoFkNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdContratoFk")
                        .IsRequired()
                        .HasConstraintName("fk_Programacion_Contrato1");

                    b.HasOne("Domain.Entities.Persona", "IdPersonaFkNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdPersonaFk")
                        .IsRequired()
                        .HasConstraintName("fk_Programacion_Persona1");

                    b.HasOne("Domain.Entities.Turno", "IdTurnoFkNavigation")
                        .WithMany("Programacions")
                        .HasForeignKey("IdTurnoFk")
                        .IsRequired()
                        .HasConstraintName("fk_Programacion_Turnos1");

                    b.Navigation("IdContratoFkNavigation");

                    b.Navigation("IdPersonaFkNavigation");

                    b.Navigation("IdTurnoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.CategoriaPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.Navigation("Programacions");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudads");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("Contactopersonas");

                    b.Navigation("Contratos");

                    b.Navigation("Direccionpersonas");

                    b.Navigation("Programacions");
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Navigation("Contactopersonas");
                });

            modelBuilder.Entity("Domain.Entities.TipoDireccion", b =>
                {
                    b.Navigation("Direccionpersonas");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Turno", b =>
                {
                    b.Navigation("Programacions");
                });
#pragma warning restore 612, 618
        }
    }
}
