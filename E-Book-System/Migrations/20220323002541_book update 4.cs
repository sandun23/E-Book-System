using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Book_System.Migrations
{
    public partial class bookupdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookImageFileName",
                table: "Books",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookImageFileName",
                table: "Books");
        }
    }
}
