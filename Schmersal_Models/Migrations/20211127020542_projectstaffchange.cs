using Microsoft.EntityFrameworkCore.Migrations;

namespace Schmersal_Models.Migrations
{
    public partial class projectstaffchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProjectStaff_tblUser_UserId",
                table: "tblProjectStaff");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tblProjectStaff",
                newName: "Userid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tblProjectStaff",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_tblProjectStaff_UserId",
                table: "tblProjectStaff",
                newName: "IX_tblProjectStaff_Userid");

            migrationBuilder.AddColumn<string>(
                name: "user_id",
                table: "tblProjectStaff",
                type: "varchar(80)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tblProjectStaff_tblUser_Userid",
                table: "tblProjectStaff",
                column: "Userid",
                principalTable: "tblUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblProjectStaff_tblUser_Userid",
                table: "tblProjectStaff");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "tblProjectStaff");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "tblProjectStaff",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tblProjectStaff",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_tblProjectStaff_Userid",
                table: "tblProjectStaff",
                newName: "IX_tblProjectStaff_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblProjectStaff_tblUser_UserId",
                table: "tblProjectStaff",
                column: "UserId",
                principalTable: "tblUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
