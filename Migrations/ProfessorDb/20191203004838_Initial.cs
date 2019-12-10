using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoTarefasIPG.Migrations.ProfessorDb
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    ProfessorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telemovel = table.Column<string>(nullable: true),
                    Numero_De_Professor = table.Column<string>(nullable: true),
                    Numero_De_Gabinete = table.Column<string>(nullable: true)
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.ProfessorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
