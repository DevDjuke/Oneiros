using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class linksaddedpreset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Presets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Presets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Presets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Presets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PresetAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresetId = table.Column<int>(type: "int", nullable: false),
                    AbilityId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresetAbilities_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PresetAbilities_Presets_PresetId",
                        column: x => x.PresetId,
                        principalTable: "Presets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PresetFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresetId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresetFeatures_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PresetFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PresetFeatures_Presets_PresetId",
                        column: x => x.PresetId,
                        principalTable: "Presets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PresetLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresetId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresetLanguages_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PresetLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PresetLanguages_Presets_PresetId",
                        column: x => x.PresetId,
                        principalTable: "Presets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PresetSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresetId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PresetSkills_Presets_PresetId",
                        column: x => x.PresetId,
                        principalTable: "Presets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PresetSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presets_RaceId",
                table: "Presets",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetAbilities_CharacterId",
                table: "PresetAbilities",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetAbilities_PresetId",
                table: "PresetAbilities",
                column: "PresetId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetFeatures_CharacterId",
                table: "PresetFeatures",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetFeatures_FeatureId",
                table: "PresetFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetFeatures_PresetId",
                table: "PresetFeatures",
                column: "PresetId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetLanguages_CharacterId",
                table: "PresetLanguages",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetLanguages_LanguageId",
                table: "PresetLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetLanguages_PresetId",
                table: "PresetLanguages",
                column: "PresetId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetSkills_PresetId",
                table: "PresetSkills",
                column: "PresetId");

            migrationBuilder.CreateIndex(
                name: "IX_PresetSkills_SkillId",
                table: "PresetSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Presets_Races_RaceId",
                table: "Presets",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presets_Races_RaceId",
                table: "Presets");

            migrationBuilder.DropTable(
                name: "PresetAbilities");

            migrationBuilder.DropTable(
                name: "PresetFeatures");

            migrationBuilder.DropTable(
                name: "PresetLanguages");

            migrationBuilder.DropTable(
                name: "PresetSkills");

            migrationBuilder.DropIndex(
                name: "IX_Presets_RaceId",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Presets");
        }
    }
}
