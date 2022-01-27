using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class roanokestocampaign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerRoanokes_Roanokes_RoanokeId",
                table: "PlayerRoanokes");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSkills_Roanokes_RoanokeId",
                table: "PlayerSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roanokes",
                table: "Roanokes");

            migrationBuilder.RenameTable(
                name: "Roanokes",
                newName: "Campaigns");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerRoanokes_Campaigns_RoanokeId",
                table: "PlayerRoanokes",
                column: "RoanokeId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSkills_Campaigns_RoanokeId",
                table: "PlayerSkills",
                column: "RoanokeId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerRoanokes_Campaigns_RoanokeId",
                table: "PlayerRoanokes");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSkills_Campaigns_RoanokeId",
                table: "PlayerSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns");

            migrationBuilder.RenameTable(
                name: "Campaigns",
                newName: "Roanokes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roanokes",
                table: "Roanokes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerRoanokes_Roanokes_RoanokeId",
                table: "PlayerRoanokes",
                column: "RoanokeId",
                principalTable: "Roanokes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSkills_Roanokes_RoanokeId",
                table: "PlayerSkills",
                column: "RoanokeId",
                principalTable: "Roanokes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
