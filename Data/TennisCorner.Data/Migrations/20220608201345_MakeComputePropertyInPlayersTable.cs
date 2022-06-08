using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TennisCorner.Data.Migrations
{
    public partial class MakeComputePropertyInPlayersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Players",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(yy, DateOfBirth, GETDATE()) - CASE WHEN (MONTH(DateOfBirth) >= MONTH(GETDATE()))  AND DAY(DateOfBirth) > DAY(GETDATE()) THEN 1 ELSE 0 END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Players");
        }
    }
}
