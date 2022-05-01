using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class dietplandaydish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_DietPlanDays_DietPlanDayId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_DietPlanDayId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "DietPlanDayId",
                table: "Dish");

            migrationBuilder.AlterColumn<bool>(
                name: "FoodHeatingAbility",
                table: "Interview",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DietPlanDayId",
                table: "DietPlanDayDishes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanDayDishes_DietPlanDayId",
                table: "DietPlanDayDishes",
                column: "DietPlanDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDayDishes_DietPlanDays_DietPlanDayId",
                table: "DietPlanDayDishes",
                column: "DietPlanDayId",
                principalTable: "DietPlanDays",
                principalColumn: "DietPlanDayId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDayDishes_DietPlanDays_DietPlanDayId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropIndex(
                name: "IX_DietPlanDayDishes_DietPlanDayId",
                table: "DietPlanDayDishes");

            migrationBuilder.DropColumn(
                name: "DietPlanDayId",
                table: "DietPlanDayDishes");

            migrationBuilder.AlterColumn<bool>(
                name: "FoodHeatingAbility",
                table: "Interview",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "DietPlanDayId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_DietPlanDayId",
                table: "Dish",
                column: "DietPlanDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_DietPlanDays_DietPlanDayId",
                table: "Dish",
                column: "DietPlanDayId",
                principalTable: "DietPlanDays",
                principalColumn: "DietPlanDayId");
        }
    }
}
