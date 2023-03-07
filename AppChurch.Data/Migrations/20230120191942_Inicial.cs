using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppChurch.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dizimo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    MesReferente = table.Column<string>(type: "text", nullable: true),
                    MembroId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizimo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Logradoro = table.Column<string>(type: "text", nullable: true),
                    numero = table.Column<int>(type: "integer", nullable: false),
                    CEP = table.Column<int>(type: "integer", nullable: false),
                    Complemento = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    sexo = table.Column<string>(type: "text", nullable: true),
                    DataConversao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataBatismo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EnrecoId = table.Column<Guid>(type: "uuid", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DizimoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Membro_Dizimo_DizimoId",
                        column: x => x.DizimoId,
                        principalTable: "Dizimo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Membro_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Membro_DizimoId",
                table: "Membro",
                column: "DizimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Membro_EnderecoId",
                table: "Membro",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Membro");

            migrationBuilder.DropTable(
                name: "Dizimo");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
