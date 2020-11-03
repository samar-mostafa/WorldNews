using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldNews.Data.Migrations
{
    public partial class AddNewPropToNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Disc",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disc",
                table: "News");
        }
    }
}
