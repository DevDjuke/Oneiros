using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class npclanguageupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PresetLanguages_Characters_CharacterId",
                table: "PresetLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_PresetLanguages_NPCs_NonPlayerId",
                table: "PresetLanguages");

            migrationBuilder.DropIndex(
                name: "IX_PresetLanguages_CharacterId",
                table: "PresetLanguages");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "PresetLanguages");

            migrationBuilder.DropColumn(
                name: "PresetId",
                table: "PresetLanguages");

            migrationBuilder.AlterColumn<int>(
                name: "NonPlayerId",
                table: "PresetLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PresetLanguages_NPCs_NonPlayerId",
                table: "PresetLanguages",
                column: "NonPlayerId",
                principalTable: "NPCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PresetLanguages_NPCs_NonPlayerId",
                table: "PresetLanguages");

            migrationBuilder.AlterColumn<int>(
                name: "NonPlayerId",
                table: "PresetLanguages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "PresetLanguages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PresetId",
                table: "PresetLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PresetLanguages_CharacterId",
                table: "PresetLanguages",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_PresetLanguages_Characters_CharacterId",
                table: "PresetLanguages",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PresetLanguages_NPCs_NonPlayerId",
                table: "PresetLanguages",
                column: "NonPlayerId",
                principalTable: "NPCs",
                principalColumn: "Id");
        }
    }
}
