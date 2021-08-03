using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mentoria.GGR.Migrations
{
    public partial class CriacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    AtualizadoEM = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RemovidoEm = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Poderes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPoder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Força = table.Column<int>(type: "int", nullable: false),
                    Fraqueza = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    AtualizadoEM = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RemovidoEm = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poderes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHasPoder",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonagemID = table.Column<int>(type: "int", nullable: false),
                    PoderID = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    AtualizadoEM = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    RemovidoEm = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHasPoder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PersonagemHasPoder_Personagens_PersonagemID",
                        column: x => x.PersonagemID,
                        principalTable: "Personagens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHasPoder_Poderes_PoderID",
                        column: x => x.PoderID,
                        principalTable: "Poderes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHasPoder_PersonagemID",
                table: "PersonagemHasPoder",
                column: "PersonagemID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHasPoder_PoderID",
                table: "PersonagemHasPoder",
                column: "PoderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHasPoder");

            migrationBuilder.DropTable(
                name: "Personagens");

            migrationBuilder.DropTable(
                name: "Poderes");
        }
    }
}
