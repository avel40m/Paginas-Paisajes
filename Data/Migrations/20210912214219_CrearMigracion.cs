using Microsoft.EntityFrameworkCore.Migrations;

namespace Paisajes.Data.Migrations
{
    public partial class CrearMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiudadModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiudadModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaisModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvinciaModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinciaModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaisajeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Lugar = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: true),
                    Valoracion = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPais = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProvincia = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCiudad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaisajeModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaisajeModel_CiudadModel_IdCiudad",
                        column: x => x.IdCiudad,
                        principalTable: "CiudadModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaisajeModel_PaisModel_IdPais",
                        column: x => x.IdPais,
                        principalTable: "PaisModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaisajeModel_ProvinciaModel_IdProvincia",
                        column: x => x.IdProvincia,
                        principalTable: "ProvinciaModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaisajeModel_IdCiudad",
                table: "PaisajeModel",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_PaisajeModel_IdPais",
                table: "PaisajeModel",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_PaisajeModel_IdProvincia",
                table: "PaisajeModel",
                column: "IdProvincia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaisajeModel");

            migrationBuilder.DropTable(
                name: "CiudadModel");

            migrationBuilder.DropTable(
                name: "PaisModel");

            migrationBuilder.DropTable(
                name: "ProvinciaModel");
        }
    }
}
