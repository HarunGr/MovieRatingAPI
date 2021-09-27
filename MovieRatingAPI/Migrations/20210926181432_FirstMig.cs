using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingAPI.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MOVIES",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "TEXT", nullable: false),
                    TITLE = table.Column<string>(type: "TEXT", nullable: true),
                    DIRECTOR = table.Column<string>(type: "TEXT", nullable: true),
                    ACTORS = table.Column<string>(type: "TEXT", nullable: true),
                    POSTER = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIES", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MOVIES");
        }
    }
}
