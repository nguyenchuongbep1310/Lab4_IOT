using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThietBi",
                columns: table => new
                {
                    MaThietBi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThietBi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhietDo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoAm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnhSang = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBi", x => x.MaThietBi);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThietBi");
        }
    }
}
