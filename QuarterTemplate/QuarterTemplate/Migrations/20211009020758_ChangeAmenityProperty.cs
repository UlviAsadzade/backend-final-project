using Microsoft.EntityFrameworkCore.Migrations;

namespace QuarterTemplate.Migrations
{
    public partial class ChangeAmenityProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Amenities_AmenityId",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Products_ProductId",
                table: "Amenities");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_AmenityId",
                table: "Amenities");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_ProductId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "AmenityId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Amenities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmenityId",
                table: "Amenities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Amenities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_AmenityId",
                table: "Amenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_ProductId",
                table: "Amenities",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Amenities_AmenityId",
                table: "Amenities",
                column: "AmenityId",
                principalTable: "Amenities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Products_ProductId",
                table: "Amenities",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
