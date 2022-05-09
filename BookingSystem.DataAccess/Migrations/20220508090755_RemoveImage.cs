using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingSystem.DAL.Migrations
{
    public partial class RemoveImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Branches");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Room",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Hotels",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Branches",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
