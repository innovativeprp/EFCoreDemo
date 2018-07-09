using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo.Migrations
{
    public partial class AddContactFullAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StreetNumber",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "StreetNumber",
                table: "Contacts");
        }
    }
}
