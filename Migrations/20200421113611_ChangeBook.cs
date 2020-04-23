using Microsoft.EntityFrameworkCore.Migrations;

namespace Site.Migrations
{
    public partial class ChangeBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Books");

            migrationBuilder.AddColumn<bool>(
                name: "isHave",
                table: "Books",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isHave",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
