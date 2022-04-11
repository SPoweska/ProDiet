using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class oneinterview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Interview_PatientId",
                table: "Interview");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_PatientId",
                table: "Interview",
                column: "PatientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Interview_PatientId",
                table: "Interview");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_PatientId",
                table: "Interview",
                column: "PatientId");
        }
    }
}
