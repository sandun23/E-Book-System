using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Book_System.Migrations
{
    public partial class AddBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<string>(nullable: false),
                    BookName = table.Column<string>(nullable: false),
                    BookDesc = table.Column<string>(maxLength: 1000, nullable: false),
                    BookPrice = table.Column<decimal>(nullable: false),
                    BookAuthorName = table.Column<string>(nullable: false),
                    BookCategory = table.Column<string>(nullable: false),
                    BookType = table.Column<string>(nullable: false),
                    Created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
