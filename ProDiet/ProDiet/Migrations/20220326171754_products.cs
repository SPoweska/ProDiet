using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProDiet.Migrations
{
    public partial class products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alegrene");

            migrationBuilder.RenameColumn(
                name: "NutrientName",
                table: "Nutrients",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "Alergene",
                columns: table => new
                {
                    AlergeneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlergeneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alergene", x => x.AlergeneId);
                    table.ForeignKey(
                        name: "FK_Alergene_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alergene_ProductId",
                table: "Alergene",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alergene");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Nutrients",
                newName: "NutrientName");

            migrationBuilder.CreateTable(
                name: "Alegrene",
                columns: table => new
                {
                    AlergeneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AlergeneName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alegrene", x => x.AlergeneId);
                    table.ForeignKey(
                        name: "FK_Alegrene_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alegrene_ProductId",
                table: "Alegrene",
                column: "ProductId");
        }
    }
}
