using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class dietplanmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDays_DietPlans_DietPlanId",
                table: "DietPlanDays");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "DietPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "DietPlanId",
                table: "DietPlanDays",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DietPlans_PatientId",
                table: "DietPlans",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDays_DietPlans_DietPlanId",
                table: "DietPlanDays",
                column: "DietPlanId",
                principalTable: "DietPlans",
                principalColumn: "DietPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlans_Patient_PatientId",
                table: "DietPlans",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietPlanDays_DietPlans_DietPlanId",
                table: "DietPlanDays");

            migrationBuilder.DropForeignKey(
                name: "FK_DietPlans_Patient_PatientId",
                table: "DietPlans");

            migrationBuilder.DropIndex(
                name: "IX_DietPlans_PatientId",
                table: "DietPlans");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "DietPlans");

            migrationBuilder.AlterColumn<int>(
                name: "DietPlanId",
                table: "DietPlanDays",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DietPlanDays_DietPlans_DietPlanId",
                table: "DietPlanDays",
                column: "DietPlanId",
                principalTable: "DietPlans",
                principalColumn: "DietPlanId");
        }
    }
}
