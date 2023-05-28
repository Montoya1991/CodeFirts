using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code_First.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Lib_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lib_Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_Autor = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_Genero = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_TipoProyecto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lib_Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Lib_id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolDescripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RolStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Per_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Per_LibId = table.Column<int>(type: "int", nullable: false),
                    Per_RolId = table.Column<int>(type: "int", nullable: false),
                    Per_Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Per_LugarNacimiento = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Per_Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    libroLib_id = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Per_Id);
                    table.ForeignKey(
                        name: "FK_Personajes_Libros_libroLib_id",
                        column: x => x.libroLib_id,
                        principalTable: "Libros",
                        principalColumn: "Lib_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personajes_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_libroLib_id",
                table: "Personajes",
                column: "libroLib_id");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_RolId",
                table: "Personajes",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
