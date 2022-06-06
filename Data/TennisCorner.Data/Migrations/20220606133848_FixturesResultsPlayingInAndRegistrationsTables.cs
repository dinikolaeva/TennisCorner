#nullable disable

namespace TennisCorner.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class FixturesResultsPlayingInAndRegistrationsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrizeMoney",
                table: "Players",
                newName: "TotalPrizeMoney");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Players",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "Players",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "FixtureResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FixtureId = table.Column<int>(type: "int", nullable: false),
                    WinnerRegistrationId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: true),
                    NumberOfSetsPlayed = table.Column<int>(type: "int", nullable: false),
                    IsOpponentRetired = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixtureResults", x => new { x.Id, x.FixtureId });
                });

            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentPlayingCategoryId = table.Column<int>(type: "int", nullable: false),
                    FirstRegistrationId = table.Column<int>(type: "int", nullable: false),
                    SecondRegistrationId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: true),
                    Round = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fixtures_TournamentPlayingCategories_TournamentPlayingCategoryId",
                        column: x => x.TournamentPlayingCategoryId,
                        principalTable: "TournamentPlayingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayingIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentPlayingCategoryId = table.Column<int>(type: "int", nullable: false),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    Seed = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayingIn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayingIn_TournamentPlayingCategories_TournamentPlayingCategoryId",
                        column: x => x.TournamentPlayingCategoryId,
                        principalTable: "TournamentPlayingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlayingInId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_PlayingIn_PlayingInId",
                        column: x => x.PlayingInId,
                        principalTable: "PlayingIn",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RegistrationsPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationsPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationsPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistrationsPlayers_Registrations_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FixtureResults_FixtureId",
                table: "FixtureResults",
                column: "FixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_FixtureResults_IsDeleted",
                table: "FixtureResults",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FixtureResults_RegistrationId",
                table: "FixtureResults",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_IsDeleted",
                table: "Fixtures",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_RegistrationId",
                table: "Fixtures",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_TournamentPlayingCategoryId",
                table: "Fixtures",
                column: "TournamentPlayingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayingIn_IsDeleted",
                table: "PlayingIn",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_PlayingIn_RegistrationId",
                table: "PlayingIn",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayingIn_TournamentPlayingCategoryId",
                table: "PlayingIn",
                column: "TournamentPlayingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_IsDeleted",
                table: "Registrations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_PlayerId",
                table: "Registrations",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_PlayingInId",
                table: "Registrations",
                column: "PlayingInId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationsPlayers_IsDeleted",
                table: "RegistrationsPlayers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationsPlayers_PlayerId",
                table: "RegistrationsPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationsPlayers_RegistrationId",
                table: "RegistrationsPlayers",
                column: "RegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_FixtureResults_Fixtures_FixtureId",
                table: "FixtureResults",
                column: "FixtureId",
                principalTable: "Fixtures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FixtureResults_Registrations_RegistrationId",
                table: "FixtureResults",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fixtures_Registrations_RegistrationId",
                table: "Fixtures",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayingIn_Registrations_RegistrationId",
                table: "PlayingIn",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayingIn_Registrations_RegistrationId",
                table: "PlayingIn");

            migrationBuilder.DropTable(
                name: "FixtureResults");

            migrationBuilder.DropTable(
                name: "RegistrationsPlayers");

            migrationBuilder.DropTable(
                name: "Fixtures");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "PlayingIn");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "TotalPrizeMoney",
                table: "Players",
                newName: "PrizeMoney");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
