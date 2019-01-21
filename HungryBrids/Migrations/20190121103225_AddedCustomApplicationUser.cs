using Microsoft.EntityFrameworkCore.Migrations;

namespace HungryBirds.Migrations
{
    public partial class AddedCustomApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomUserField",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomUserField",
                table: "AspNetUsers");
        }
    }
}
