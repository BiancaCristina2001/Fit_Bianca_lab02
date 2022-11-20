using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fit_Bianca_lab02.Migrations
{
    public partial class AuthorFirstName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Author",
                newName: "AuthorLastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Author",
                newName: "AuthorFirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorLastName",
                table: "Author",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "AuthorFirstName",
                table: "Author",
                newName: "FirstName");
        }
    }
}
