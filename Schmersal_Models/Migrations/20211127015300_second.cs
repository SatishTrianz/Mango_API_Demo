using Microsoft.EntityFrameworkCore.Migrations;

namespace Schmersal_Models.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblOffers_tblContact_Contactid",
                table: "TblOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblService_tblContact_Contactid",
                table: "tblService");

            migrationBuilder.RenameColumn(
                name: "Contactid",
                table: "tblService",
                newName: "contact_id1");

            migrationBuilder.RenameIndex(
                name: "IX_tblService_Contactid",
                table: "tblService",
                newName: "IX_tblService_contact_id1");

            migrationBuilder.RenameColumn(
                name: "Contactid",
                table: "TblOffers",
                newName: "contact_id1");

            migrationBuilder.RenameIndex(
                name: "IX_TblOffers_Contactid",
                table: "TblOffers",
                newName: "IX_TblOffers_contact_id1");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "tblContact",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tblContact",
                newName: "contact_id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblOffers_tblContact_contact_id1",
                table: "TblOffers",
                column: "contact_id1",
                principalTable: "tblContact",
                principalColumn: "contact_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblService_tblContact_contact_id1",
                table: "tblService",
                column: "contact_id1",
                principalTable: "tblContact",
                principalColumn: "contact_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblOffers_tblContact_contact_id1",
                table: "TblOffers");

            migrationBuilder.DropForeignKey(
                name: "FK_tblService_tblContact_contact_id1",
                table: "tblService");

            migrationBuilder.RenameColumn(
                name: "contact_id1",
                table: "tblService",
                newName: "Contactid");

            migrationBuilder.RenameIndex(
                name: "IX_tblService_contact_id1",
                table: "tblService",
                newName: "IX_tblService_Contactid");

            migrationBuilder.RenameColumn(
                name: "contact_id1",
                table: "TblOffers",
                newName: "Contactid");

            migrationBuilder.RenameIndex(
                name: "IX_TblOffers_contact_id1",
                table: "TblOffers",
                newName: "IX_TblOffers_Contactid");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "tblContact",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "contact_id",
                table: "tblContact",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblOffers_tblContact_Contactid",
                table: "TblOffers",
                column: "Contactid",
                principalTable: "tblContact",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblService_tblContact_Contactid",
                table: "tblService",
                column: "Contactid",
                principalTable: "tblContact",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
