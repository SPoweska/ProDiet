using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyMeasurement_Patient_PatientId",
                table: "BodyMeasurement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyMeasurement",
                table: "BodyMeasurement");

            migrationBuilder.RenameTable(
                name: "BodyMeasurement",
                newName: "BodyMeasurements");

            migrationBuilder.RenameIndex(
                name: "IX_BodyMeasurement_PatientId",
                table: "BodyMeasurements",
                newName: "IX_BodyMeasurements_PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyMeasurements",
                table: "BodyMeasurements",
                column: "MeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyMeasurements_Patient_PatientId",
                table: "BodyMeasurements",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyMeasurements_Patient_PatientId",
                table: "BodyMeasurements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BodyMeasurements",
                table: "BodyMeasurements");

            migrationBuilder.RenameTable(
                name: "BodyMeasurements",
                newName: "BodyMeasurement");

            migrationBuilder.RenameIndex(
                name: "IX_BodyMeasurements_PatientId",
                table: "BodyMeasurement",
                newName: "IX_BodyMeasurement_PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BodyMeasurement",
                table: "BodyMeasurement",
                column: "MeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyMeasurement_Patient_PatientId",
                table: "BodyMeasurement",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
