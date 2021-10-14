using Microsoft.EntityFrameworkCore.Migrations;

namespace QuarterTemplate.Migrations
{
    public partial class AddedAdresImageinSettingsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdressImage",
                table: "Settings",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoImage",
                table: "Settings",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressImage",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "VideoImage",
                table: "Settings");
        }
    }
}
