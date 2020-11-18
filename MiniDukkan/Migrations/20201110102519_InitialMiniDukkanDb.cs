using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniDukkan.Migrations
{
    public partial class InitialMiniDukkanDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal (6,2)", nullable: false),
                    Kategori = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
