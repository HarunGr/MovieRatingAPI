using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRatingAPI.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "POSTER",
                table: "MOVIES",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "BLOB",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPTION",
                table: "MOVIES",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "RATING",
                table: "MOVIES",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRIPTION",
                table: "MOVIES");

            migrationBuilder.DropColumn(
                name: "RATING",
                table: "MOVIES");

            migrationBuilder.AlterColumn<byte[]>(
                name: "POSTER",
                table: "MOVIES",
                type: "BLOB",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
