using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingAPI.Migrations
{
    public partial class kor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RATINGS",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "TEXT", nullable: false),
                    MOVIE_ID = table.Column<decimal>(type: "TEXT", nullable: false),
                    RATING = table.Column<decimal>(type: "TEXT", nullable: true),
                    VOTES = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RATINGS", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RATINGS");
        }
    }
}
