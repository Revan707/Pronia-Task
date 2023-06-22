using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronia.DataAccess.Migrations
{
    public partial class AddColumnBannersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageDesc",
                table: "Banners",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageDesc",
                table: "Banners");
        }
    }
}
