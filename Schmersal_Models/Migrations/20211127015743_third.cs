using Microsoft.EntityFrameworkCore.Migrations;

namespace Schmersal_Models.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCustomer_tblContact_contactId",
                table: "tblCustomer");

            migrationBuilder.RenameColumn(
                name: "countryCode",
                table: "tblCustomer",
                newName: "country_code");

            migrationBuilder.RenameColumn(
                name: "contactId",
                table: "tblCustomer",
                newName: "contact_id1");

            migrationBuilder.RenameIndex(
                name: "IX_tblCustomer_contactId",
                table: "tblCustomer",
                newName: "IX_tblCustomer_contact_id1");

            migrationBuilder.AddColumn<string>(
                name: "contact_id",
                table: "tblCustomer",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblCustomer_tblContact_contact_id1",
                table: "tblCustomer",
                column: "contact_id1",
                principalTable: "tblContact",
                principalColumn: "contact_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCustomer_tblContact_contact_id1",
                table: "tblCustomer");

            migrationBuilder.DropColumn(
                name: "contact_id",
                table: "tblCustomer");

            migrationBuilder.RenameColumn(
                name: "country_code",
                table: "tblCustomer",
                newName: "countryCode");

            migrationBuilder.RenameColumn(
                name: "contact_id1",
                table: "tblCustomer",
                newName: "contactId");

            migrationBuilder.RenameIndex(
                name: "IX_tblCustomer_contact_id1",
                table: "tblCustomer",
                newName: "IX_tblCustomer_contactId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCustomer_tblContact_contactId",
                table: "tblCustomer",
                column: "contactId",
                principalTable: "tblContact",
                principalColumn: "contact_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
