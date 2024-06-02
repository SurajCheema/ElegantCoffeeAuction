using Microsoft.EntityFrameworkCore.Migrations;

namespace ElegantCoffeeImplementation.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
