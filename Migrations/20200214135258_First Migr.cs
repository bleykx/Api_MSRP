using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_MSPR.Migrations
{
    public partial class FirstMigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) 
        {
            migrationBuilder.CreateTable(
                name: "InfoQRs",
                columns: table => new
                {
                    IdPromo = table.Column<int>(nullable: false),
                    IdQRCode = table.Column<int>(nullable: false),
                    Localisation = table.Column<string>(nullable: true),
                    DateScan = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoQRs", x => new { x.IdPromo, x.IdQRCode });
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodePromo = table.Column<int>(nullable: false),
                    PromoDateDeb = table.Column<DateTime>(nullable: false),
                    PromoDateFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QRCodes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbScan = table.Column<int>(nullable: false),
                    PromotionID = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QRCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_QRCodes_Promotions_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QRCodes_PromotionID",
                table: "QRCodes",
                column: "PromotionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoQRs");

            migrationBuilder.DropTable(
                name: "QRCodes");

            migrationBuilder.DropTable(
                name: "Promotions");
        }
    }
}
