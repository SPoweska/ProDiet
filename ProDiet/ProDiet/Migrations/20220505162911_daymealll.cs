using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class daymealll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDishes_DayMeals_DayMealMealId",
                table: "MealDishes");

            migrationBuilder.AlterColumn<int>(
                name: "DayMealMealId",
                table: "MealDishes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MealDishes_DayMeals_DayMealMealId",
                table: "MealDishes",
                column: "DayMealMealId",
                principalTable: "DayMeals",
                principalColumn: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealDishes_DayMeals_DayMealMealId",
                table: "MealDishes");

            migrationBuilder.AlterColumn<int>(
                name: "DayMealMealId",
                table: "MealDishes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MealDishes_DayMeals_DayMealMealId",
                table: "MealDishes",
                column: "DayMealMealId",
                principalTable: "DayMeals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
