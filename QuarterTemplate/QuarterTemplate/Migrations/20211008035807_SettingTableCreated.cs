using Microsoft.EntityFrameworkCore.Migrations;

namespace QuarterTemplate.Migrations
{
    public partial class SettingTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderLogo = table.Column<string>(maxLength: 100, nullable: true),
                    FooterLogo = table.Column<string>(maxLength: 100, nullable: true),
                    Phone1 = table.Column<string>(maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(maxLength: 100, nullable: true),
                    Email2 = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    LocationIcon = table.Column<string>(maxLength: 100, nullable: true),
                    LocationImage = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneIcon = table.Column<string>(maxLength: 100, nullable: true),
                    PhoneImage = table.Column<string>(maxLength: 100, nullable: true),
                    EmailIcon = table.Column<string>(maxLength: 100, nullable: true),
                    EmailImage = table.Column<string>(maxLength: 100, nullable: true),
                    FacebookIcon = table.Column<string>(maxLength: 100, nullable: true),
                    TwitterIcon = table.Column<string>(maxLength: 100, nullable: true),
                    LinkedinIcon = table.Column<string>(maxLength: 100, nullable: true),
                    YoutubeIcon = table.Column<string>(maxLength: 100, nullable: true),
                    AboutImage1 = table.Column<string>(maxLength: 100, nullable: true),
                    AboutImage2 = table.Column<string>(maxLength: 100, nullable: true),
                    AboutTitle = table.Column<string>(maxLength: 100, nullable: true),
                    AboutDesc = table.Column<string>(maxLength: 300, nullable: true),
                    AboutText = table.Column<string>(maxLength: 100, nullable: true),
                    AboutRedirrectUrl = table.Column<string>(maxLength: 100, nullable: true),
                    AboutUrlText = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
