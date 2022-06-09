using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisCorner.Data.Migrations
{
    public partial class AddChangesInTournamentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FinalsSchemaManImageUrl",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FinalsSchemaWomenImageUrl",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManWinnerImageUrl",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TournamentImageUrl",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WomanWinnerImageUrl",
                table: "Tournaments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalsSchemaManImageUrl",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "FinalsSchemaWomenImageUrl",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "ManWinnerImageUrl",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "TournamentImageUrl",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "WomanWinnerImageUrl",
                table: "Tournaments");
        }
    }
}
