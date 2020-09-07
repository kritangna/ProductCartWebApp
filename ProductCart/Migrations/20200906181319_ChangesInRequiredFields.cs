using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCart.Migrations
{
    public partial class ChangesInRequiredFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProdName",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProdName",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
