using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class dietplandaydish1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Calories",
                table: "DietPlanDays",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Carbohydrates",
                table: "DietPlanDays",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fats",
                table: "DietPlanDays",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fiber",
                table: "DietPlanDays",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Proteins",
                table: "DietPlanDays",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Calories",
                table: "DietPlanDayDishes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Carbohydrates",
                table: "DietPlanDayDishes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fats",
                table: "DietPlanDayDishes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fiber",
                table: "DietPlanDayDishes",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Proteins",
                table: "DietPlanDayDishes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Servings",
                table: "DietPlanDayDishes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "DietPlanDays");

            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "DietPlanDays");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "DietPlanDays");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "DietPlanDays");

            migrationBuilder.DropColumn(
                name: "Proteins",
                table: "DietPlanDays");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "DietPlanDayDishes");

            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "DietPlanDayDishes");

            migrationBuilder.DropColumn(
                name: "Fats",
                table: "DietPlanDayDishes");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "DietPlanDayDishes");

            migrationBuilder.DropColumn(
                name: "Proteins",
                table: "DietPlanDayDishes");

            migrationBuilder.DropColumn(
                name: "Servings",
                table: "DietPlanDayDishes");
        }
    }
}
