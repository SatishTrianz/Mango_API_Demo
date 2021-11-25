using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schmersal_Models.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblProject",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(80)", nullable: false),
                    Erp_Project_Id = table.Column<string>(type: "varchar(80)", nullable: true),
                    Project_Name = table.Column<string>(type: "varchar(80)", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", nullable: true),
                    CustomerId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "DateTime", nullable: false),
                    End_Date = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", nullable: true),
                    Controlling_Id = table.Column<string>(type: "varchar(50)", nullable: false),
                    Tenant_Id = table.Column<string>(type: "varchar(50)", nullable: true),
                    Company_Id = table.Column<string>(type: "varchar(50)", nullable: true),
                    Customer_Id = table.Column<string>(type: "varchar(50)", nullable: true),
                    Staff_Id = table.Column<string>(type: "varchar(50)", nullable: true),
                    Created_At = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    Created_By = table.Column<string>(type: "varchar(50)", nullable: true),
                    Modified_At = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    Modified_By = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProject", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblProject");
        }
    }
}
