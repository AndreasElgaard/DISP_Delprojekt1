using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Iniiiiiiiiiiiiit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    VTKFarve = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaerktoejskasser", x => x.VTKId);
                });

            migrationBuilder.CreateTable(
                name: "Haandværkere",
                columns: table => new
                {
                    haandvaerkerId = table.Column<int>(type: "int", nullable: false),
                    HVAnsaettelsedato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HVEfternavn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HVFagomraade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HVFornavn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haandværkere", x => x.haandvaerkerId);
                    table.ForeignKey(
                        name: "FK_Haandværkere_Vaerktoejskasser_haandvaerkerId",
                        column: x => x.haandvaerkerId,
                        principalTable: "Vaerktoejskasser",
                        principalColumn: "VTKId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaerktøjer",
                columns: table => new
                {
                    VTId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Vaerktøjer_Vaerktoejskasser_VTId",
                        column: x => x.VTId,
                        principalTable: "Vaerktoejskasser",
                        principalColumn: "VTKId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haandværkere");

            migrationBuilder.DropTable(
                name: "Vaerktøjer");

            migrationBuilder.DropTable(
                name: "Vaerktoejskasser");
        }
    }
}
