using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class fake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanionsEpisodeSummary",
                columns: table => new
                {
                    CompanionId = table.Column<int>(type: "int", nullable: false),
                    CompanionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EnemiesEpisodeSummary",
                columns: table => new
                {
                    EnemyId = table.Column<int>(type: "int", nullable: false),
                    EnemyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanionsEpisodeSummary");

            migrationBuilder.DropTable(
                name: "EnemiesEpisodeSummary");
        }
    }
}
