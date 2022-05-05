using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class update1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DayDishId",
                table: "MealDishes",
                newName: "MealDishId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MealDishId",
                table: "MealDishes",
                newName: "DayDishId");
        }
    }
}
