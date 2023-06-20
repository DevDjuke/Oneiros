using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oneiros.API.Migrations
{
    public partial class npcbaseclassfixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presets_Classes_BaseClassId",
                table: "Presets");

            migrationBuilder.DropColumn(
                name: "classId",
                table: "Presets");

            migrationBuilder.AlterColumn<int>(
                name: "BaseClassId",
                table: "Presets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Presets_Classes_BaseClassId",
                table: "Presets",
                column: "BaseClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presets_Classes_BaseClassId",
                table: "Presets");

            migrationBuilder.AlterColumn<int>(
                name: "BaseClassId",
                table: "Presets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "classId",
                table: "Presets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Presets_Classes_BaseClassId",
                table: "Presets",
                column: "BaseClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }
    }
}
