using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Book_System.Migrations
{
    public partial class ordertableadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookQty",
                table: "Books",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookQty",
                table: "Books");
        }
    }
}
