using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class alergeneconfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAlergene_Interview_InterviewId",
                table: "PatientAlergene");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientIntolerance_Interview_InterviewId",
                table: "PatientIntolerance");

            migrationBuilder.RenameColumn(
                name: "InterviewId",
                table: "PatientIntolerance",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientIntolerance_InterviewId",
                table: "PatientIntolerance",
                newName: "IX_PatientIntolerance_PatientId");

            migrationBuilder.RenameColumn(
                name: "InterviewId",
                table: "PatientAlergene",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAlergene_InterviewId",
                table: "PatientAlergene",
                newName: "IX_PatientAlergene_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAlergene_Patient_PatientId",
                table: "PatientAlergene",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientIntolerance_Patient_PatientId",
                table: "PatientIntolerance",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientAlergene_Patient_PatientId",
                table: "PatientAlergene");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientIntolerance_Patient_PatientId",
                table: "PatientIntolerance");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "PatientIntolerance",
                newName: "InterviewId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientIntolerance_PatientId",
                table: "PatientIntolerance",
                newName: "IX_PatientIntolerance_InterviewId");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "PatientAlergene",
                newName: "InterviewId");

            migrationBuilder.RenameIndex(
                name: "IX_PatientAlergene_PatientId",
                table: "PatientAlergene",
                newName: "IX_PatientAlergene_InterviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAlergene_Interview_InterviewId",
                table: "PatientAlergene",
                column: "InterviewId",
                principalTable: "Interview",
                principalColumn: "InterviewId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientIntolerance_Interview_InterviewId",
                table: "PatientIntolerance",
                column: "InterviewId",
                principalTable: "Interview",
                principalColumn: "InterviewId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
