using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class wupiwop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Haandværkere_Vaerktoejskasser_Id",
                table: "Haandværkere");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_Id",
                table: "Vaerktøjer");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vaerktøjer",
                newName: "VTId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Vaerktoejskasser",
                newName: "VTKId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Haandværkere",
                newName: "haandvaerkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Haandværkere_Vaerktoejskasser_haandvaerkerId",
                table: "Haandværkere",
                column: "haandvaerkerId",
                principalTable: "Vaerktoejskasser",
                principalColumn: "VTKId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_VTId",
                table: "Vaerktøjer",
                column: "VTId",
                principalTable: "Vaerktoejskasser",
                principalColumn: "VTKId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Haandværkere_Vaerktoejskasser_haandvaerkerId",
                table: "Haandværkere");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_VTId",
                table: "Vaerktøjer");

            migrationBuilder.RenameColumn(
                name: "VTId",
                table: "Vaerktøjer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "VTKId",
                table: "Vaerktoejskasser",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "haandvaerkerId",
                table: "Haandværkere",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Haandværkere_Vaerktoejskasser_Id",
                table: "Haandværkere",
                column: "Id",
                principalTable: "Vaerktoejskasser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_Id",
                table: "Vaerktøjer",
                column: "Id",
                principalTable: "Vaerktoejskasser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
