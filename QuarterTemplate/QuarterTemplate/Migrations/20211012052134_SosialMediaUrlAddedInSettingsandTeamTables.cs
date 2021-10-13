using Microsoft.EntityFrameworkCore.Migrations;

namespace QuarterTemplate.Migrations
{
    public partial class SosialMediaUrlAddedInSettingsandTeamTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Teams",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Teams",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "Teams",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeUrl",
                table: "Teams",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Settings",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Settings",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "Settings",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YoutubeUrl",
                table: "Settings",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "YoutubeUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "YoutubeUrl",
                table: "Settings");
        }
    }
}
