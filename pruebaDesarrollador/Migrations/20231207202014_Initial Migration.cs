using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pruebaDesarrollador.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cotizador",
                columns: table => new
                {
                    tazaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valorRendimiento = table.Column<float>(type: "real", nullable: false),
                    MontoRecibir = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizador", x => x.tazaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotizador");
        }
    }
}
