using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFuAgency.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Impiegato",
                columns: table => new
                {
                    EntrepriseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RakingPoints = table.Column<int>(type: "int", nullable: false),
                    ImmagineProfilo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dipartimento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impiegato", x => x.EntrepriseId);
                });

            migrationBuilder.CreateTable(
                name: "Dipartimenti",
                columns: table => new
                {
                    GeoCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmagineDipartimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaderEntrepriseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipartimenti", x => x.GeoCode);
                    table.ForeignKey(
                        name: "FK_Dipartimenti_Impiegato_LeaderEntrepriseId",
                        column: x => x.LeaderEntrepriseId,
                        principalTable: "Impiegato",
                        principalColumn: "EntrepriseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dipartimenti_LeaderEntrepriseId",
                table: "Dipartimenti",
                column: "LeaderEntrepriseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dipartimenti");

            migrationBuilder.DropTable(
                name: "Impiegato");
        }
    }
}
