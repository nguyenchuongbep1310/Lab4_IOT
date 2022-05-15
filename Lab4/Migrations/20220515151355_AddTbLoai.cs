using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4.Migrations
{
    public partial class AddTbLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "Loai",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "Loai");
        }
    }
}
