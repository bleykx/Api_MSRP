using Microsoft.EntityFrameworkCore.Migrations;

namespace API_MSPR.Migrations
{
    public partial class CorrectionIdPromo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QRCodes_Promotions_PromotionID",
                table: "QRCodes");

            migrationBuilder.DropIndex(
                name: "IX_QRCodes_PromotionID",
                table: "QRCodes");

            migrationBuilder.RenameColumn(
                name: "PromotionID",
                table: "QRCodes",
                newName: "PromotionId");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "QRCodes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PromotionId",
                table: "QRCodes",
                newName: "PromotionID");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionID",
                table: "QRCodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_QRCodes_PromotionID",
                table: "QRCodes",
                column: "PromotionID");

            migrationBuilder.AddForeignKey(
                name: "FK_QRCodes_Promotions_PromotionID",
                table: "QRCodes",
                column: "PromotionID",
                principalTable: "Promotions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
