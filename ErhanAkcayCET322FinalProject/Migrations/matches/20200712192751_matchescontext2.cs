using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ErhanAkcayCET322FinalProject.Migrations.matches
{
    public partial class matchescontext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MatchName",
                table: "MatchReport",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MatchScore",
                table: "MatchReport",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "MatchReport",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchName",
                table: "MatchReport");

            migrationBuilder.DropColumn(
                name: "MatchScore",
                table: "MatchReport");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "MatchReport");
        }
    }
}
