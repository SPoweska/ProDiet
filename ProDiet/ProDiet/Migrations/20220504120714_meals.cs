using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class meals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDayDishes_DietPlanDays_DietPlanDayId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.RenameColumn(
                name: "DietPlanDayId",
                table: "DietPlanDayDishes",
                newName: "DayMealId");

            migrationBuilder.RenameIndex(
                name: "IX_DietPlanDayDishes_DietPlanDayId",
                table: "DietPlanDayDishes",
                newName: "IX_DietPlanDayDishes_DayMealId");

            migrationBuilder.CreateTable(
                name: "DayMeal",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DietPlanDayId = table.Column<int>(type: "int", nullable: false),
                    Carbohydrates = table.Column<float>(type: "real", nullable: false),
                    Fats = table.Column<float>(type: "real", nullable: false),
                    Proteins = table.Column<float>(type: "real", nullable: false),
                    Fiber = table.Column<float>(type: "real", nullable: true),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayMeal", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_DayMeal_DietPlanDays_DietPlanDayId",
                        column: x => x.DietPlanDayId,
                        principalTable: "DietPlanDays",
                        principalColumn: "DietPlanDayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayMeal_DietPlanDayId",
                table: "DayMeal",
                column: "DietPlanDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDayDishes_DayMeal_DayMealId",
                table: "DietPlanDayDishes",
                column: "DayMealId",
                principalTable: "DayMeal",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDayDishes_DayMeal_DayMealId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropTable(
                name: "DayMeal");

            migrationBuilder.RenameColumn(
                name: "DayMealId",
                table: "DietPlanDayDishes",
                newName: "DietPlanDayId");

            migrationBuilder.RenameIndex(
                name: "IX_DietPlanDayDishes_DayMealId",
                table: "DietPlanDayDishes",
                newName: "IX_DietPlanDayDishes_DietPlanDayId");

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietPlanId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealDailySharePercent = table.Column<float>(type: "real", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealId);
                    table.ForeignKey(
                        name: "FK_Meals_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "DietPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DietPlanId",
                table: "Meals",
                column: "DietPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDayDishes_DietPlanDays_DietPlanDayId",
                table: "DietPlanDayDishes",
                column: "DietPlanDayId",
                principalTable: "DietPlanDays",
                principalColumn: "DietPlanDayId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
