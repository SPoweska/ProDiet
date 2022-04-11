using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class interview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DailySnacksAmount",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DietHistory",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DigestiveDiseases",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Diseases",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyDiseases",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "FoodHeatingAbility",
                table: "Interview",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Goals",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HealthProblems",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastMealTime",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PALActivity",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhysicalActivity",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedBreads",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedCarbProducts",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedDairy",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedDrinks",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedFats",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedFish",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedMeat",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedSnacks",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreferedSweeteners",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Suplementation",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TimeWhenEatsMost",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TypicalEatingShedules",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnlikedFoods",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VisitGoal",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VisitReason",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyAlkohol",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyBread",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyCandies",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyDairy",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyFastFoods",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyFish",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyFlourProducts",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyMeat",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeeklyVegetables",
                table: "Interview",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PatientAlergene",
                columns: table => new
                {
                    AlergeneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlergeneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAlergene", x => x.AlergeneId);
                    table.ForeignKey(
                        name: "FK_PatientAlergene_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "InterviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientIntolerance",
                columns: table => new
                {
                    IntoleranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntoleranceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterviewId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientIntolerance", x => x.IntoleranceId);
                    table.ForeignKey(
                        name: "FK_PatientIntolerance_Interview_InterviewId",
                        column: x => x.InterviewId,
                        principalTable: "Interview",
                        principalColumn: "InterviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientAlergene_InterviewId",
                table: "PatientAlergene",
                column: "InterviewId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientIntolerance_InterviewId",
                table: "PatientIntolerance",
                column: "InterviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientAlergene");

            migrationBuilder.DropTable(
                name: "PatientIntolerance");

            migrationBuilder.DropColumn(
                name: "DailySnacksAmount",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "DietHistory",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "DigestiveDiseases",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "Diseases",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "FamilyDiseases",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "FoodHeatingAbility",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "HealthProblems",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "LastMealTime",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PALActivity",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PhysicalActivity",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedBreads",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedCarbProducts",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedDairy",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedDrinks",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedFats",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedFish",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedMeat",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedSnacks",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PreferedSweeteners",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "Suplementation",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "TimeWhenEatsMost",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "TypicalEatingShedules",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "UnlikedFoods",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "VisitGoal",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "VisitReason",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyAlkohol",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyBread",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyCandies",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyDairy",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyFastFoods",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyFish",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyFlourProducts",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyMeat",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "WeeklyVegetables",
                table: "Interview");
        }
    }
}
