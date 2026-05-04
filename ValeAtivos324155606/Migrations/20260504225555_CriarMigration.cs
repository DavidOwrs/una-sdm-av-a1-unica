using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValeAtivos324155606.Migrations
{
    /// <inheritdoc />
    public partial class CriarMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true),
                    Localizacao = table.Column<string>(type: "TEXT", nullable: true),
                    CapacidadeProcessamento = table.Column<double>(type: "REAL", nullable: false),
                    DataUltimaManutencao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmOperacao = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipamentos");
        }
    }
}
