using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class modelsBetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaerktoejskasser_Haandværkere_HaandvaerkerId",
                table: "Vaerktoejskasser");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_VaerktoejskasseId",
                table: "Vaerktøjer");

            migrationBuilder.DropIndex(
                name: "IX_Vaerktøjer_VaerktoejskasseId",
                table: "Vaerktøjer");

            migrationBuilder.DropIndex(
                name: "IX_Vaerktoejskasser_HaandvaerkerId",
                table: "Vaerktoejskasser");

            migrationBuilder.DropColumn(
                name: "HaandvaerkerId",
                table: "Vaerktoejskasser");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Vaerktøjer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Haandværkere",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Haandværkere_Vaerktoejskasser_Id",
                table: "Haandværkere");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_Id",
                table: "Vaerktøjer");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Vaerktøjer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "HaandvaerkerId",
                table: "Vaerktoejskasser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Haandværkere",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Vaerktøjer_VaerktoejskasseId",
                table: "Vaerktøjer",
                column: "VaerktoejskasseId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaerktoejskasser_HaandvaerkerId",
                table: "Vaerktoejskasser",
                column: "HaandvaerkerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaerktoejskasser_Haandværkere_HaandvaerkerId",
                table: "Vaerktoejskasser",
                column: "HaandvaerkerId",
                principalTable: "Haandværkere",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaerktøjer_Vaerktoejskasser_VaerktoejskasseId",
                table: "Vaerktøjer",
                column: "VaerktoejskasseId",
                principalTable: "Vaerktoejskasser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
