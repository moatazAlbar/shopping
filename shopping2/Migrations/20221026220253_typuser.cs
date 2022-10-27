using Microsoft.EntityFrameworkCore.Migrations;

namespace shopping2.Migrations
{
    public partial class typuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TypeUser",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeUser",
                table: "AspNetUsers");
        }
    }
}
