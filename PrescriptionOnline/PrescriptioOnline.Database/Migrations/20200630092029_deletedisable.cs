using Microsoft.EntityFrameworkCore.Migrations;

namespace PrescriptioOnline.Database.Migrations
{
    public partial class deletedisable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAbleToMakePrescriptions",
                table: "Doctors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAbleToMakePrescriptions",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
