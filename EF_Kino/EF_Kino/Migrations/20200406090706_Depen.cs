using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Kino.Migrations
{
    public partial class Depen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Seanse",
                table: "Seanse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Miejsca",
                table: "Miejsca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kina",
                table: "Kina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bilety",
                table: "Bilety");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresy",
                table: "Adresy");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Seanse");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Miejsca");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Kina");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Kina");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Bilety");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Adresy");

            migrationBuilder.AddColumn<int>(
                name: "IdSeansu",
                table: "Seanse",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdSali",
                table: "Sale",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "KinoIdKina",
                table: "Sale",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdMiejsca",
                table: "Miejsca",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SalaIdSali",
                table: "Miejsca",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdKina",
                table: "Kina",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdBiletu",
                table: "Bilety",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "MiejsceIdMiejsca",
                table: "Bilety",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeansIdSeansu",
                table: "Bilety",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAdresu",
                table: "Adresy",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seanse",
                table: "Seanse",
                column: "IdSeansu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "IdSali");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miejsca",
                table: "Miejsca",
                column: "IdMiejsca");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kina",
                table: "Kina",
                column: "IdKina");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bilety",
                table: "Bilety",
                column: "IdBiletu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresy",
                table: "Adresy",
                column: "IdAdresu");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_KinoIdKina",
                table: "Sale",
                column: "KinoIdKina");

            migrationBuilder.CreateIndex(
                name: "IX_Miejsca_SalaIdSali",
                table: "Miejsca",
                column: "SalaIdSali");

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_MiejsceIdMiejsca",
                table: "Bilety",
                column: "MiejsceIdMiejsca");

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_SeansIdSeansu",
                table: "Bilety",
                column: "SeansIdSeansu");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresy_Kina_IdAdresu",
                table: "Adresy",
                column: "IdAdresu",
                principalTable: "Kina",
                principalColumn: "IdKina",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilety_Miejsca_MiejsceIdMiejsca",
                table: "Bilety",
                column: "MiejsceIdMiejsca",
                principalTable: "Miejsca",
                principalColumn: "IdMiejsca",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilety_Seanse_SeansIdSeansu",
                table: "Bilety",
                column: "SeansIdSeansu",
                principalTable: "Seanse",
                principalColumn: "IdSeansu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Miejsca_Sale_SalaIdSali",
                table: "Miejsca",
                column: "SalaIdSali",
                principalTable: "Sale",
                principalColumn: "IdSali",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Kina_KinoIdKina",
                table: "Sale",
                column: "KinoIdKina",
                principalTable: "Kina",
                principalColumn: "IdKina",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresy_Kina_IdAdresu",
                table: "Adresy");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilety_Miejsca_MiejsceIdMiejsca",
                table: "Bilety");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilety_Seanse_SeansIdSeansu",
                table: "Bilety");

            migrationBuilder.DropForeignKey(
                name: "FK_Miejsca_Sale_SalaIdSali",
                table: "Miejsca");

            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Kina_KinoIdKina",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seanse",
                table: "Seanse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sale",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_KinoIdKina",
                table: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Miejsca",
                table: "Miejsca");

            migrationBuilder.DropIndex(
                name: "IX_Miejsca_SalaIdSali",
                table: "Miejsca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kina",
                table: "Kina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bilety",
                table: "Bilety");

            migrationBuilder.DropIndex(
                name: "IX_Bilety_MiejsceIdMiejsca",
                table: "Bilety");

            migrationBuilder.DropIndex(
                name: "IX_Bilety_SeansIdSeansu",
                table: "Bilety");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresy",
                table: "Adresy");

            migrationBuilder.DropColumn(
                name: "IdSeansu",
                table: "Seanse");

            migrationBuilder.DropColumn(
                name: "IdSali",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "KinoIdKina",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "IdMiejsca",
                table: "Miejsca");

            migrationBuilder.DropColumn(
                name: "SalaIdSali",
                table: "Miejsca");

            migrationBuilder.DropColumn(
                name: "IdKina",
                table: "Kina");

            migrationBuilder.DropColumn(
                name: "IdBiletu",
                table: "Bilety");

            migrationBuilder.DropColumn(
                name: "MiejsceIdMiejsca",
                table: "Bilety");

            migrationBuilder.DropColumn(
                name: "SeansIdSeansu",
                table: "Bilety");

            migrationBuilder.DropColumn(
                name: "IdAdresu",
                table: "Adresy");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Seanse",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Sale",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Miejsca",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Kina",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Kina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Bilety",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Adresy",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seanse",
                table: "Seanse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sale",
                table: "Sale",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miejsca",
                table: "Miejsca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kina",
                table: "Kina",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bilety",
                table: "Bilety",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresy",
                table: "Adresy",
                column: "Id");
        }
    }
}
