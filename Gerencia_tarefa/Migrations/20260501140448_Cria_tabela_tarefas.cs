using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gerencia_tarefa.Migrations
{
    /// <inheritdoc />
    public partial class Cria_tabela_tarefas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarefa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario_inicio = table.Column<TimeOnly>(type: "time", nullable: false),
                    Horario_fim = table.Column<TimeOnly>(type: "time", nullable: false),
                    Prazo_final = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
