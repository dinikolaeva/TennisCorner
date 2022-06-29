using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisCorner.Data.Migrations
{
    public partial class AddChangeInTournamentsPlayersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TournamentsPlayers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "TournamentsPlayers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TournamentsPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TournamentsPlayers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "TournamentsPlayers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Coach",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateIndex(
                name: "IX_TournamentsPlayers_IsDeleted",
                table: "TournamentsPlayers",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TournamentsPlayers_IsDeleted",
                table: "TournamentsPlayers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TournamentsPlayers");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "TournamentsPlayers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TournamentsPlayers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TournamentsPlayers");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "TournamentsPlayers");

            migrationBuilder.AlterColumn<string>(
                name: "Coach",
                table: "Players",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
