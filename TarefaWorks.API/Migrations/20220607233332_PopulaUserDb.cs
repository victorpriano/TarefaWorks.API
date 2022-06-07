using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TarefaWorks.API.Migrations
{
    public partial class PopulaUserDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users(UserName, Password, Role) " +
                "VALUES('Usuario1', '12345', 'Desenvolvedor')");
            migrationBuilder.Sql("INSERT INTO Users(UserName, Password, Role) " +
                "VALUES('Usuario2', '12345', 'PO')");
            migrationBuilder.Sql("INSERT INTO Users(UserName, Password, Role) " +
                "VALUES('Usuario3', '12345', 'Designer')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users");
        }
    }
}
