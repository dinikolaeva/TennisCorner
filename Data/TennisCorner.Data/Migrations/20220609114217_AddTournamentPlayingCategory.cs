#nullable disable

namespace TennisCorner.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddTournamentPlayingCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TournamentPlayingCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    PlayingCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentPlayingCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TournamentPlayingCategories_PlayingCategories_PlayingCategoryId",
                        column: x => x.PlayingCategoryId,
                        principalTable: "PlayingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TournamentPlayingCategories_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TournamentPlayingCategories_IsDeleted",
                table: "TournamentPlayingCategories",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentPlayingCategories_PlayingCategoryId",
                table: "TournamentPlayingCategories",
                column: "PlayingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentPlayingCategories_TournamentId",
                table: "TournamentPlayingCategories",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TournamentPlayingCategories");
        }
    }
}
