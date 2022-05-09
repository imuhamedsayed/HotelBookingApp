using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.DAL.Migrations
{
    public partial class removereleationhgddc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserRooms",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserRooms");
        }
    }
}
