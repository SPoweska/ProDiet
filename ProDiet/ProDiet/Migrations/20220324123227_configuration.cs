using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Interviews_InterviewId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_InterviewId",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interviews",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "InterviewId",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "Interviews",
                newName: "Interview");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Interview",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interview",
                table: "Interview",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_PatientId",
                table: "Interview",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interview_Patient_PatientId",
                table: "Interview",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interview_Patient_PatientId",
                table: "Interview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interview",
                table: "Interview");

            migrationBuilder.DropIndex(
                name: "IX_Interview_PatientId",
                table: "Interview");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Interview");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Interview",
                newName: "Interviews");

            migrationBuilder.AddColumn<int>(
                name: "InterviewId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interviews",
                table: "Interviews",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_InterviewId",
                table: "Patients",
                column: "InterviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Interviews_InterviewId",
                table: "Patients",
                column: "InterviewId",
                principalTable: "Interviews",
                principalColumn: "Id");
        }
    }
}
