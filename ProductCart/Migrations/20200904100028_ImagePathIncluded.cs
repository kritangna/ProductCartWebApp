using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCart.Migrations
{
    public partial class ImagePathIncluded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdImg",
                table: "Products",
                newName: "ProdImgPath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdImgPath",
                table: "Products",
                newName: "ProdImg");
        }
    }
}
