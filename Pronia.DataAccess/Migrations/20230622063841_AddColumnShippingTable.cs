using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronia.DataAccess.Migrations
{
    public partial class AddColumnShippingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageDesc",
                table: "Shippings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageDesc",
                table: "Shippings");
        }
    }
}
