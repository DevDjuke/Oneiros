using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class npcbaseclassadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseClassId",
                table: "Presets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "classId",
                table: "Presets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Presets_BaseClassId",
                table: "Presets",
                column: "BaseClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Presets_Classes_BaseClassId",
                table: "Presets",
                column: "BaseClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presets_Classes_BaseClassId",
                table: "Presets");

            migrationBuilder.DropIndex(
                name: "IX_Presets_BaseClassId",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "BaseClassId",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "classId",
                table: "Presets");
        }
    }
}
