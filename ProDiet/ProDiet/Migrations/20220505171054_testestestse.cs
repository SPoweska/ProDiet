using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class testestestse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DayMeals_MealDishId",
                table: "DayMeals");

            migrationBuilder.CreateIndex(
                name: "IX_DayMeals_MealDishId",
                table: "DayMeals",
                column: "MealDishId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DayMeals_MealDishId",
                table: "DayMeals");

            migrationBuilder.CreateIndex(
                name: "IX_DayMeals_MealDishId",
                table: "DayMeals",
                column: "MealDishId",
                unique: true);
        }
    }
}
