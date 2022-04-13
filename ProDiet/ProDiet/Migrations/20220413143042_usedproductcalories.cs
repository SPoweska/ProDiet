using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class usedproductcalories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Calories",
                table: "UsedProduct",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Carbohydrates",
                table: "UsedProduct",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fats",
                table: "UsedProduct",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fiber",
                table: "UsedProduct",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Proteins",
                table: "UsedProduct",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "UsedProduct");

            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "UsedProduct");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "UsedProduct");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "UsedProduct");

            migrationBuilder.DropColumn(
                name: "Proteins",
                table: "UsedProduct");
        }
    }
}
