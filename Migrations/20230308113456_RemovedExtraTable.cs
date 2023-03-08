using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrder.Migrations
{
    /// <inheritdoc />
    public partial class RemovedExtraTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants_Foods");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_RestaurantId",
                table: "Foods",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Restaurants_RestaurantId",
                table: "Foods",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Restaurants_RestaurantId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_RestaurantId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Foods");

            migrationBuilder.CreateTable(
                name: "Restaurants_Foods",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants_Foods", x => new { x.RestaurantId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_Restaurants_Foods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurants_Foods_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_Foods_FoodId",
                table: "Restaurants_Foods",
                column: "FoodId");
        }
    }
}
