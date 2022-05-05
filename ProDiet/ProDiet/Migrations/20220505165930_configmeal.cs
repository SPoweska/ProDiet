using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class configmeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDishes_DayMeals_DayMealMealId",
                table: "MealDishes");

            migrationBuilder.DropIndex(
                name: "IX_MealDishes_DayMealMealId",
                table: "MealDishes");

            migrationBuilder.DropColumn(
                name: "DayMealMealId",
                table: "MealDishes");

            migrationBuilder.AddColumn<int>(
                name: "MealDishId",
                table: "DayMeals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DayMeals_MealDishId",
                table: "DayMeals",
                column: "MealDishId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DayMeals_MealDishes_MealDishId",
                table: "DayMeals",
                column: "MealDishId",
                principalTable: "MealDishes",
                principalColumn: "MealDishId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayMeals_MealDishes_MealDishId",
                table: "DayMeals");

            migrationBuilder.DropIndex(
                name: "IX_DayMeals_MealDishId",
                table: "DayMeals");

            migrationBuilder.DropColumn(
                name: "MealDishId",
                table: "DayMeals");

            migrationBuilder.AddColumn<int>(
                name: "DayMealMealId",
                table: "MealDishes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MealDishes_DayMealMealId",
                table: "MealDishes",
                column: "DayMealMealId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealDishes_DayMeals_DayMealMealId",
                table: "MealDishes",
                column: "DayMealMealId",
                principalTable: "DayMeals",
                principalColumn: "MealId");
        }
    }
}
