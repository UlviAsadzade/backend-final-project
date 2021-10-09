using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuarterTemplate.Migrations
{
    public partial class ProductsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmenityId",
                table: "Amenities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Amenities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CostPrice = table.Column<double>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    Desc = table.Column<string>(maxLength: 500, nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    HomeArea = table.Column<double>(nullable: false),
                    Rooms = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false),
                    Bathrooms = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(maxLength: 100, nullable: true),
                    WhichFloor = table.Column<int>(nullable: true),
                    HouseFloor = table.Column<int>(nullable: true),
                    ParkingCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    AmenityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAmenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAmenities_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(maxLength: 100, nullable: true),
                    IsPoster = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_AmenityId",
                table: "Amenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_ProductId",
                table: "Amenities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAmenities_AmenityId",
                table: "ProductAmenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAmenities_ProductId",
                table: "ProductAmenities",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CityId",
                table: "Products",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StatusId",
                table: "Products",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TeamId",
                table: "Products",
                column: "TeamId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Amenities_AmenityId",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Products_ProductId",
                table: "Amenities");

            migrationBuilder.DropTable(
                name: "ProductAmenities");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Products");

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
    }
}
