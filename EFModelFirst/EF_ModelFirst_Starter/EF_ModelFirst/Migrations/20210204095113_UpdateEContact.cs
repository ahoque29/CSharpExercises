using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_ModelFirst.Migrations
{
    public partial class UpdateEContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmergencyContact",
                columns: table => new
                {
                    EmergencyContactId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContact", x => x.EmergencyContactId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEmergencyContact",
                columns: table => new
                {
                    CustomersCustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmergencyContactsEmergencyContactId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEmergencyContact", x => new { x.CustomersCustomerId, x.EmergencyContactsEmergencyContactId });
                    table.ForeignKey(
                        name: "FK_CustomerEmergencyContact_Customers_CustomersCustomerId",
                        column: x => x.CustomersCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerEmergencyContact_EmergencyContact_EmergencyContactsEmergencyContactId",
                        column: x => x.EmergencyContactsEmergencyContactId,
                        principalTable: "EmergencyContact",
                        principalColumn: "EmergencyContactId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmergencyContact_EmergencyContactsEmergencyContactId",
                table: "CustomerEmergencyContact",
                column: "EmergencyContactsEmergencyContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerEmergencyContact");

            migrationBuilder.DropTable(
                name: "EmergencyContact");
        }
    }
}
