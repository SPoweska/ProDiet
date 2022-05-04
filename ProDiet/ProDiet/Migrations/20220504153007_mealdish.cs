using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class mealdish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayMeal_DietPlanDays_DietPlanDayId",
                table: "DayMeal");

            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDayDishes_DayMeal_DayMealId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropIndex(
                name: "IX_DietPlanDayDishes_DayMealId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DayMeal",
                table: "DayMeal");

            migrationBuilder.RenameTable(
                name: "DayMeal",
                newName: "DayMeals");

            migrationBuilder.RenameIndex(
                name: "IX_DayMeal_DietPlanDayId",
                table: "DayMeals",
                newName: "IX_DayMeals_DietPlanDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DayMeals",
                table: "DayMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanDayDishes_DayMealId",
                table: "DietPlanDayDishes",
                column: "DayMealId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DayMeals_DietPlanDays_DietPlanDayId",
                table: "DayMeals",
                column: "DietPlanDayId",
                principalTable: "DietPlanDays",
                principalColumn: "DietPlanDayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDayDishes_DayMeals_DayMealId",
                table: "DietPlanDayDishes",
                column: "DayMealId",
                principalTable: "DayMeals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayMeals_DietPlanDays_DietPlanDayId",
                table: "DayMeals");

            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDayDishes_DayMeals_DayMealId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropIndex(
                name: "IX_DietPlanDayDishes_DayMealId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DayMeals",
                table: "DayMeals");

            migrationBuilder.RenameTable(
                name: "DayMeals",
                newName: "DayMeal");

            migrationBuilder.RenameIndex(
                name: "IX_DayMeals_DietPlanDayId",
                table: "DayMeal",
                newName: "IX_DayMeal_DietPlanDayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DayMeal",
                table: "DayMeal",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanDayDishes_DayMealId",
                table: "DietPlanDayDishes",
                column: "DayMealId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayMeal_DietPlanDays_DietPlanDayId",
                table: "DayMeal",
                column: "DietPlanDayId",
                principalTable: "DietPlanDays",
                principalColumn: "DietPlanDayId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDayDishes_DayMeal_DayMealId",
                table: "DietPlanDayDishes",
                column: "DayMealId",
                principalTable: "DayMeal",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
