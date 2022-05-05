using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class testetstetset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_MealDishes_MealId",
                table: "MealDishes",
                column: "MealId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MealDishes_DayMeals_MealId",
                table: "MealDishes",
                column: "MealId",
                principalTable: "DayMeals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDishes_DayMeals_MealId",
                table: "MealDishes");

            migrationBuilder.DropIndex(
                name: "IX_MealDishes_MealId",
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
                column: "MealDishId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayMeals_MealDishes_MealDishId",
                table: "DayMeals",
                column: "MealDishId",
                principalTable: "MealDishes",
                principalColumn: "MealDishId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
