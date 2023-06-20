using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class charactertobuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Characters_CharacterId",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Presets_PresetId",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_PresetLanguages_Presets_PresetId",
                table: "PresetLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_Presets_Races_RaceId",
                table: "Presets");

            migrationBuilder.DropIndex(
                name: "IX_Presets_RaceId",
                table: "Presets");

            migrationBuilder.DropIndex(
                name: "IX_PresetLanguages_PresetId",
                table: "PresetLanguages");

            migrationBuilder.DropIndex(
                name: "IX_NPCs_CharacterId",
                table: "NPCs");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "NPCs");

            migrationBuilder.RenameColumn(
                name: "PresetId",
                table: "NPCs",
                newName: "RaceId");

            migrationBuilder.RenameIndex(
                name: "IX_NPCs_PresetId",
                table: "NPCs",
                newName: "IX_NPCs_RaceId");

            migrationBuilder.AddColumn<int>(
                name: "NonPlayerId",
                table: "PresetLanguages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Builds_Presets_PresetId",
                        column: x => x.PresetId,
                        principalTable: "Presets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NonPlayerBuilds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NonPlayerId = table.Column<int>(type: "int", nullable: false),
                    BuildId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonPlayerBuilds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NonPlayerBuilds_Builds_BuildId",
                        column: x => x.BuildId,
                        principalTable: "Builds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NonPlayerBuilds_NPCs_NonPlayerId",
                        column: x => x.NonPlayerId,
                        principalTable: "NPCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PresetLanguages_NonPlayerId",
                table: "PresetLanguages",
                column: "NonPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Builds_PresetId",
                table: "Builds",
                column: "PresetId");

            migrationBuilder.CreateIndex(
                name: "IX_NonPlayerBuilds_BuildId",
                table: "NonPlayerBuilds",
                column: "BuildId");

            migrationBuilder.CreateIndex(
                name: "IX_NonPlayerBuilds_NonPlayerId",
                table: "NonPlayerBuilds",
                column: "NonPlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Races_RaceId",
                table: "NPCs",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PresetLanguages_NPCs_NonPlayerId",
                table: "PresetLanguages",
                column: "NonPlayerId",
                principalTable: "NPCs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Races_RaceId",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_PresetLanguages_NPCs_NonPlayerId",
                table: "PresetLanguages");

            migrationBuilder.DropTable(
                name: "NonPlayerBuilds");

            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropIndex(
                name: "IX_PresetLanguages_NonPlayerId",
                table: "PresetLanguages");

            migrationBuilder.DropColumn(
                name: "NonPlayerId",
                table: "PresetLanguages");

            migrationBuilder.RenameColumn(
                name: "RaceId",
                table: "NPCs",
                newName: "PresetId");

            migrationBuilder.RenameIndex(
                name: "IX_NPCs_RaceId",
                table: "NPCs",
                newName: "IX_NPCs_PresetId");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Presets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "NPCs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Presets_RaceId",
                table: "Presets",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetLanguages_PresetId",
                table: "PresetLanguages",
                column: "PresetId");

            migrationBuilder.CreateIndex(
                name: "IX_NPCs_CharacterId",
                table: "NPCs",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Characters_CharacterId",
                table: "NPCs",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Presets_PresetId",
                table: "NPCs",
                column: "PresetId",
                principalTable: "Presets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PresetLanguages_Presets_PresetId",
                table: "PresetLanguages",
                column: "PresetId",
                principalTable: "Presets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Presets_Races_RaceId",
                table: "Presets",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id");
        }
    }
}
