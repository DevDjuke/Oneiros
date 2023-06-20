using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class npcnameadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "NPCs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "NPCs");
        }
    }
}
