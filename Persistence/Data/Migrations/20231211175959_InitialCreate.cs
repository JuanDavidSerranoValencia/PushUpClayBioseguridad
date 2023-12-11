using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categoriapersona",
                columns: table => new
                {
                    Id_CategoriaPer = table.Column<int>(type: "int", nullable: false),
                    NombreCat = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_CategoriaPer);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id_Estado = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Estado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id_Pais = table.Column<int>(type: "int", nullable: false),
                    NombrePais = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Pais);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipocontacto",
                columns: table => new
                {
                    Id_TipoContacto = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_TipoContacto);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipodireccion",
                columns: table => new
                {
                    Id_TipoDireccion = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_TipoDireccion);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipopersona",
                columns: table => new
                {
                    Id_TipoPersona = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_TipoPersona);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "turnos",
                columns: table => new
                {
                    Id_Turnos = table.Column<int>(type: "int", nullable: false),
                    nombreTurnos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    horaTurnoIng = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    horaTurnoFin = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Turnos);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id_Departamento = table.Column<int>(type: "int", nullable: false),
                    NombreDep = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_PaisFk = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Departamento);
                    table.ForeignKey(
                        name: "fk_Departamento_Pais",
                        column: x => x.Id_PaisFk,
                        principalTable: "pais",
                        principalColumn: "Id_Pais");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    Id_Ciudad = table.Column<int>(type: "int", nullable: false),
                    NombreCiudad = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_DepartamentoFk = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Ciudad);
                    table.ForeignKey(
                        name: "fk_Ciudad_Departamento1",
                        column: x => x.Id_DepartamentoFk,
                        principalTable: "departamento",
                        principalColumn: "Id_Departamento");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Id_Persona = table.Column<uint>(type: "int unsigned", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Registro = table.Column<DateOnly>(type: "date", nullable: false),
                    Id_TipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    Id_CiudadFk = table.Column<int>(type: "int", nullable: false),
                    Id_CategoriaPersonaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "fk_Persona_CategoriaPersona1",
                        column: x => x.Id_CategoriaPersonaFk,
                        principalTable: "categoriapersona",
                        principalColumn: "Id_CategoriaPer");
                    table.ForeignKey(
                        name: "fk_Persona_Ciudad1",
                        column: x => x.Id_CiudadFk,
                        principalTable: "ciudad",
                        principalColumn: "Id_Ciudad");
                    table.ForeignKey(
                        name: "fk_Persona_TipoPersona1",
                        column: x => x.Id_TipoPersonaFk,
                        principalTable: "tipopersona",
                        principalColumn: "Id_TipoPersona");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contactopersona",
                columns: table => new
                {
                    Id_ContactoPersona = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_PersonaFk = table.Column<int>(type: "int", nullable: false),
                    Id_TipoContactoFk = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_ContactoPersona);
                    table.ForeignKey(
                        name: "fk_ContactoPersona_Persona1",
                        column: x => x.Id_PersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_ContactoPersona_TipoContacto1",
                        column: x => x.Id_TipoContactoFk,
                        principalTable: "tipocontacto",
                        principalColumn: "Id_TipoContacto");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contrato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FechaContrato = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaFin = table.Column<DateOnly>(type: "date", nullable: true),
                    Id_EstadoFk = table.Column<int>(type: "int", nullable: false),
                    Id_PersonaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                    table.ForeignKey(
                        name: "fk_Contrato_Estado1",
                        column: x => x.Id_EstadoFk,
                        principalTable: "estado",
                        principalColumn: "Id_Estado");
                    table.ForeignKey(
                        name: "fk_Contrato_Persona1",
                        column: x => x.Id_PersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "direccionpersona",
                columns: table => new
                {
                    Id_DirPersona = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_PersonaFk = table.Column<int>(type: "int", nullable: false),
                    Id_TipoDireccionFk = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_DirPersona);
                    table.ForeignKey(
                        name: "fk_DirPersona_Persona1",
                        column: x => x.Id_PersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_DireccionPersona_TipoDireccion1",
                        column: x => x.Id_TipoDireccionFk,
                        principalTable: "tipodireccion",
                        principalColumn: "Id_TipoDireccion");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "programacion",
                columns: table => new
                {
                    Id_Programacion = table.Column<int>(type: "int", nullable: false),
                    Id_ContratoFk = table.Column<int>(type: "int", nullable: false),
                    Id_TurnoFk = table.Column<int>(type: "int", nullable: false),
                    Id_PersonaFk = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id_Programacion);
                    table.ForeignKey(
                        name: "fk_Programacion_Contrato1",
                        column: x => x.Id_ContratoFk,
                        principalTable: "contrato",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_Programacion_Persona1",
                        column: x => x.Id_PersonaFk,
                        principalTable: "persona",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "fk_Programacion_Turnos1",
                        column: x => x.Id_TurnoFk,
                        principalTable: "turnos",
                        principalColumn: "Id_Turnos");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_Ciudad_Departamento1_idx",
                table: "ciudad",
                column: "Id_DepartamentoFk");

            migrationBuilder.CreateIndex(
                name: "fk_ContactoPersona_Persona1_idx",
                table: "contactopersona",
                column: "Id_PersonaFk");

            migrationBuilder.CreateIndex(
                name: "fk_ContactoPersona_TipoContacto1_idx",
                table: "contactopersona",
                column: "Id_TipoContactoFk");

            migrationBuilder.CreateIndex(
                name: "fk_Contrato_Estado1_idx",
                table: "contrato",
                column: "Id_EstadoFk");

            migrationBuilder.CreateIndex(
                name: "fk_Contrato_Persona1_idx",
                table: "contrato",
                column: "Id_PersonaFk");

            migrationBuilder.CreateIndex(
                name: "fk_Departamento_Pais_idx",
                table: "departamento",
                column: "Id_PaisFk");

            migrationBuilder.CreateIndex(
                name: "fk_DireccionPersona_TipoDireccion1_idx",
                table: "direccionpersona",
                column: "Id_TipoDireccionFk");

            migrationBuilder.CreateIndex(
                name: "fk_DirPersona_Persona1_idx",
                table: "direccionpersona",
                column: "Id_PersonaFk");

            migrationBuilder.CreateIndex(
                name: "fk_Persona_CategoriaPersona1_idx",
                table: "persona",
                column: "Id_CategoriaPersonaFk");

            migrationBuilder.CreateIndex(
                name: "fk_Persona_Ciudad1_idx",
                table: "persona",
                column: "Id_CiudadFk");

            migrationBuilder.CreateIndex(
                name: "fk_Persona_TipoPersona1_idx",
                table: "persona",
                column: "Id_TipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "fk_Programacion_Contrato1_idx",
                table: "programacion",
                column: "Id_ContratoFk");

            migrationBuilder.CreateIndex(
                name: "fk_Programacion_Persona1_idx",
                table: "programacion",
                column: "Id_PersonaFk");

            migrationBuilder.CreateIndex(
                name: "fk_Programacion_Turnos1_idx",
                table: "programacion",
                column: "Id_TurnoFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactopersona");

            migrationBuilder.DropTable(
                name: "direccionpersona");

            migrationBuilder.DropTable(
                name: "programacion");

            migrationBuilder.DropTable(
                name: "tipocontacto");

            migrationBuilder.DropTable(
                name: "tipodireccion");

            migrationBuilder.DropTable(
                name: "contrato");

            migrationBuilder.DropTable(
                name: "turnos");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "categoriapersona");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "tipopersona");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
