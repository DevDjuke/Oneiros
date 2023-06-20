using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class more_things : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCampaigns_Campaigns_CampaignId",
                table: "PlayerCampaigns");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCampaigns_Characters_CharacterId",
                table: "PlayerCampaigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerCampaigns",
                table: "PlayerCampaigns");

            migrationBuilder.RenameTable(
                name: "PlayerCampaigns",
                newName: "CampaignCharacters");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerCampaigns_CharacterId",
                table: "CampaignCharacters",
                newName: "IX_CampaignCharacters_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerCampaigns_CampaignId",
                table: "CampaignCharacters",
                newName: "IX_CampaignCharacters_CampaignId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaignCharacters",
                table: "CampaignCharacters",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RaceFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RaceFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceFeatures_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaceFeatures_FeatureId",
                table: "RaceFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceFeatures_RaceId",
                table: "RaceFeatures",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignCharacters_Campaigns_CampaignId",
                table: "CampaignCharacters",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignCharacters_Characters_CharacterId",
                table: "CampaignCharacters",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignCharacters_Campaigns_CampaignId",
                table: "CampaignCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_CampaignCharacters_Characters_CharacterId",
                table: "CampaignCharacters");

            migrationBuilder.DropTable(
                name: "RaceFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaignCharacters",
                table: "CampaignCharacters");

            migrationBuilder.RenameTable(
                name: "CampaignCharacters",
                newName: "PlayerCampaigns");

            migrationBuilder.RenameIndex(
                name: "IX_CampaignCharacters_CharacterId",
                table: "PlayerCampaigns",
                newName: "IX_PlayerCampaigns_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_CampaignCharacters_CampaignId",
                table: "PlayerCampaigns",
                newName: "IX_PlayerCampaigns_CampaignId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerCampaigns",
                table: "PlayerCampaigns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCampaigns_Campaigns_CampaignId",
                table: "PlayerCampaigns",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCampaigns_Characters_CharacterId",
                table: "PlayerCampaigns",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
