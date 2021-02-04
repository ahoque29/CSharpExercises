using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_ModelFirst.Migrations
{
    public partial class UpdateEContact2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "EmergencyContact",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "EmergencyContact");
        }
    }
}
