using Microsoft.EntityFrameworkCore.Migrations;

namespace MSDF.StudentEngagement.Persistence.Migrations
{
    public partial class RenameToAllowlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("WhitelistRegex", "LearningApp", "AllowlistRegex");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("AllowlistRegex", "LearningApp", "WhitelistRegex");
        }
    }
}
