using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCart.Migrations
{
    public partial class ChangedImageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdImagePath",
                table: "Products",
                newName: "ProdImageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdImageName",
                table: "Products",
                newName: "ProdImagePath");
        }
    }
}
