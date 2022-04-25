using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class dietplan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DietPlanShoppingListShoppingListId",
                table: "UsedProduct",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DietPlanDayId",
                table: "Dish",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DietPlanDayDishes",
                columns: table => new
                {
                    DayDishId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlanDayDishes", x => x.DayDishId);
                    table.ForeignKey(
                        name: "FK_DietPlanDayDishes_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietPlans",
                columns: table => new
                {
                    DietPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietPlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyCarbohydrates = table.Column<float>(type: "real", nullable: false),
                    DailyFats = table.Column<float>(type: "real", nullable: false),
                    DailyProteins = table.Column<float>(type: "real", nullable: false),
                    DailyFiber = table.Column<float>(type: "real", nullable: true),
                    DailyCalories = table.Column<float>(type: "real", nullable: false),
                    Recommendations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlans", x => x.DietPlanId);
                });

            migrationBuilder.CreateTable(
                name: "DietPlanDays",
                columns: table => new
                {
                    DietPlanDayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietPlanDayDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DietPlanId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlanDays", x => x.DietPlanDayId);
                    table.ForeignKey(
                        name: "FK_DietPlanDays_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "DietPlanId");
                });

            migrationBuilder.CreateTable(
                name: "DietPlanShoppingLists",
                columns: table => new
                {
                    ShoppingListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietPlanId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietPlanShoppingLists", x => x.ShoppingListId);
                    table.ForeignKey(
                        name: "FK_DietPlanShoppingLists_DietPlans_DietPlanId",
                        column: x => x.DietPlanId,
                        principalTable: "DietPlans",
                        principalColumn: "DietPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietPlanId = table.Column<int>(type: "int", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealDailySharePercent = table.Column<float>(type: "real", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "IX_UsedProduct_DietPlanShoppingListShoppingListId",
                table: "UsedProduct",
                column: "DietPlanShoppingListShoppingListId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_DietPlanDayId",
                table: "Dish",
                column: "DietPlanDayId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanDayDishes_DishId",
                table: "DietPlanDayDishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanDays_DietPlanId",
                table: "DietPlanDays",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_DietPlanShoppingLists_DietPlanId",
                table: "DietPlanShoppingLists",
                column: "DietPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_DietPlanId",
                table: "Meals",
                column: "DietPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_DietPlanDays_DietPlanDayId",
                table: "Dish",
                column: "DietPlanDayId",
                principalTable: "DietPlanDays",
                principalColumn: "DietPlanDayId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsedProduct_DietPlanShoppingLists_DietPlanShoppingListShoppingListId",
                table: "UsedProduct",
                column: "DietPlanShoppingListShoppingListId",
                principalTable: "DietPlanShoppingLists",
                principalColumn: "ShoppingListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_DietPlanDays_DietPlanDayId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_UsedProduct_DietPlanShoppingLists_DietPlanShoppingListShoppingListId",
                table: "UsedProduct");

            migrationBuilder.DropTable(
                name: "DietPlanDayDishes");

            migrationBuilder.DropTable(
                name: "DietPlanDays");

            migrationBuilder.DropTable(
                name: "DietPlanShoppingLists");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "DietPlans");

            migrationBuilder.DropIndex(
                name: "IX_UsedProduct_DietPlanShoppingListShoppingListId",
                table: "UsedProduct");

            migrationBuilder.DropIndex(
                name: "IX_Dish_DietPlanDayId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "DietPlanShoppingListShoppingListId",
                table: "UsedProduct");

            migrationBuilder.DropColumn(
                name: "DietPlanDayId",
                table: "Dish");
        }
    }
}
