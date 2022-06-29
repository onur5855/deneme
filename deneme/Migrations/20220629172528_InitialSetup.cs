using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace deneme.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "STI",
            //    columns: table => new
            //    {
            //        IslemTur = table.Column<short>(type: "smallint", nullable: false),
            //        EvrakNo = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
            //        Tarih = table.Column<int>(type: "int", nullable: false),
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MalKodu = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        Miktar = table.Column<decimal>(type: "numeric(25,6)", nullable: false),
            //        Fiyat = table.Column<decimal>(type: "numeric(25,6)", nullable: false),
            //        Tutar = table.Column<decimal>(type: "numeric(25,6)", nullable: false),
            //        Birim = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("pkSTI", x => new { x.EvrakNo, x.Tarih, x.IslemTur });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "STK",
            //    columns: table => new
            //    {
            //        MalKodu = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MalAdi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("pkSTK", x => x.MalKodu);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STI");

            migrationBuilder.DropTable(
                name: "STK");
        }
    }
}
