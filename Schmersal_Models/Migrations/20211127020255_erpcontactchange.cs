using Microsoft.EntityFrameworkCore.Migrations;

namespace Schmersal_Models.Migrations
{
    public partial class erpcontactchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "erp_eontact_id",
                table: "tblErpContact",
                newName: "erp_contact_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "erp_contact_id",
                table: "tblErpContact",
                newName: "erp_eontact_id");
        }
    }
}
