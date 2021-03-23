using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Haandværkere",
                columns: table => new
                {
                    HaandvaerkerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HVAnsaettelsedato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HVEfternavn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HVFagomraade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HVFornavn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haandværkere", x => x.HaandvaerkerId);
                });

            migrationBuilder.CreateTable(
                name: "Vaerktoejskasser",
                columns: table => new
                {
                    VTKId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VTKAnskaffet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VTKFabrikat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTKModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTKSerienummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTKFarve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaandvaerkerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaerktoejskasser", x => x.VTKId);
                    table.ForeignKey(
                        name: "FK_Vaerktoejskasser_Haandværkere_HaandvaerkerId",
                        column: x => x.HaandvaerkerId,
                        principalTable: "Haandværkere",
                        principalColumn: "HaandvaerkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaerktøjer",
                columns: table => new
                {
                    VTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VTAnskaffet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VTFabrikat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTSerienr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VTType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaerktoejskasseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaerktøjer", x => x.VTId);
                    table.ForeignKey(
                        name: "FK_Vaerktøjer_Vaerktoejskasser_VaerktoejskasseId",
                        column: x => x.VaerktoejskasseId,
                        principalTable: "Vaerktoejskasser",
                        principalColumn: "VTKId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaerktoejskasser_HaandvaerkerId",
                table: "Vaerktoejskasser",
                column: "HaandvaerkerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaerktøjer_VaerktoejskasseId",
                table: "Vaerktøjer",
                column: "VaerktoejskasseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaerktøjer");

            migrationBuilder.DropTable(
                name: "Vaerktoejskasser");

            migrationBuilder.DropTable(
                name: "Haandværkere");
        }
    }
}
