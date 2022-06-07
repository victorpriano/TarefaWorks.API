using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarefaWorks.API.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cards(Projeto, Objetivo, Descricao, TempoPrevisto, TempoSaldo, Equipe, Status) " +
                "VALUES('TarefaWorks', 'Criar Migração', 'Criar', 3, 0, 'Dev', 'Aguardando')");
            migrationBuilder.Sql("INSERT INTO Cards(Projeto, Objetivo, Descricao, TempoPrevisto, TempoSaldo, Equipe, Status) " +
                "VALUES('TarefaWorks', 'Criar API', 'Criar', 3, 0, 'Dev', 'Aguardando')");
            migrationBuilder.Sql("INSERT INTO Cards(Projeto, Objetivo, Descricao, TempoPrevisto, TempoSaldo, Equipe, Status) " +
                "VALUES('TarefaWorks', 'Criar Banco de Dados', 'Criar Banco de Dados', 3, 0, 'Dev', 'Aguardando')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cards");
        }
    }
}
