using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCart.Migrations
{
    public partial class ChangedTheImageFilePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdImgPath",
                table: "Products",
                newName: "ProdImagePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdImagePath",
                table: "Products",
                newName: "ProdImgPath");
        }
    }
}
