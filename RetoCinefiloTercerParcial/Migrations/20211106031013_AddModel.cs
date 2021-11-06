using Microsoft.EntityFrameworkCore.Migrations;

namespace RetoCinefiloTercerParcial.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinefilo",
                columns: table => new
                {
                    Genero = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Portada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiempo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalificacionIMDb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalificacionRottenTomatoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NominacionesOscars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalardonesOscars = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secuelas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precuelas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Curiosidades = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinefilo", x => x.Genero);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cinefilo");
        }
    }
}
