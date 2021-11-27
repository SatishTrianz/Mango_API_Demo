using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Schmersal_Models.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCompany",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", nullable: false),
                    company_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    company_code = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblContact",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(50)", nullable: false),
                    first_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    display_name = table.Column<string>(type: "varchar(160)", nullable: true),
                    email_address = table.Column<string>(type: "varchar(150)", nullable: true),
                    title = table.Column<string>(type: "varchar(10)", nullable: true),
                    language = table.Column<string>(type: "varchar(10)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(80)", nullable: true),
                    department = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblContact", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblControllingArea",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(50)", nullable: false),
                    controlling_area = table.Column<string>(type: "varchar(80)", nullable: true),
                    controlling_area_code = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblControllingArea", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblErpContact",
                columns: table => new
                {
                    erp_eontact_id = table.Column<string>(type: "varchar(50)", nullable: false),
                    first_name = table.Column<string>(type: "varchar(50)", nullable: true),
                    customer_id = table.Column<string>(type: "varchar(50)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    display_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    email_address = table.Column<string>(type: "varchar(150)", nullable: true),
                    title = table.Column<string>(type: "varchar(50)", nullable: true),
                    language = table.Column<string>(type: "varchar(50)", nullable: true),
                    phone_number = table.Column<string>(type: "varchar(50)", nullable: true),
                    department = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblErpContact", x => x.erp_eontact_id);
                });

            migrationBuilder.CreateTable(
                name: "tblErpCustomer",
                columns: table => new
                {
                    erp_customer_id = table.Column<string>(type: "varchar(50)", nullable: false),
                    company_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    company_code = table.Column<string>(type: "varchar(80)", nullable: true),
                    controlling_area = table.Column<string>(type: "varchar(80)", nullable: true),
                    controlling_area_code = table.Column<string>(type: "varchar(80)", nullable: true),
                    customer_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    customer_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    country_code = table.Column<string>(type: "varchar(50)", nullable: true),
                    city = table.Column<string>(type: "varchar(50)", nullable: true),
                    zipcode = table.Column<string>(type: "varchar(50)", nullable: true),
                    street = table.Column<string>(type: "varchar(150)", nullable: true),
                    phone_number = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblErpCustomer", x => x.erp_customer_id);
                });

            migrationBuilder.CreateTable(
                name: "tblMachinemaster",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    machine_name = table.Column<string>(type: "varchar(160)", nullable: true),
                    machine_type = table.Column<string>(type: "varchar(80)", nullable: true),
                    manufacturer = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMachinemaster", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblProject",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    erp_project_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    project_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    description = table.Column<string>(type: "varchar(160)", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<string>(type: "varchar(80)", nullable: true),
                    controlling_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    tenant_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    company_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    customer_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    staff_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProject", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblTenantCatalog",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    client_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    region = table.Column<string>(type: "varchar(80)", nullable: true),
                    country = table.Column<string>(type: "varchar(80)", nullable: true),
                    language = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTenantCatalog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    first_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    display_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    login_name = table.Column<string>(type: "varchar(80)", nullable: true),
                    email_address = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblCustomer",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(50)", nullable: false),
                    customer_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    erp_customer_id = table.Column<string>(type: "varchar(50)", nullable: true),
                    contactId = table.Column<string>(type: "varchar(50)", nullable: true),
                    countryCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    city = table.Column<string>(type: "varchar(50)", nullable: true),
                    zipcode = table.Column<string>(type: "varchar(50)", nullable: true),
                    street = table.Column<string>(type: "varchar(150)", nullable: true),
                    phone_number = table.Column<string>(type: "varchar(50)", nullable: true),
                    language = table.Column<string>(type: "varchar(50)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomer", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblCustomer_tblContact_contactId",
                        column: x => x.contactId,
                        principalTable: "tblContact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblMachine",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    master_machine_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    machine_name = table.Column<string>(type: "varchar(160)", nullable: true),
                    asset_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    serial_number = table.Column<string>(type: "varchar(80)", nullable: true),
                    machine_description = table.Column<byte[]>(type: "varbinary(150)", nullable: true),
                    estimated_hours = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    MasterMachineid = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMachine", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblMachine_tblMachinemaster_MasterMachineid",
                        column: x => x.MasterMachineid,
                        principalTable: "tblMachinemaster",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblOffers",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    quote_type = table.Column<string>(type: "varchar(250)", nullable: true),
                    notes = table.Column<string>(type: "varchar(250)", nullable: true),
                    project_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    contact_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    status = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    Contactid = table.Column<string>(type: "varchar(50)", nullable: true),
                    Projectid = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOffers", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblOffers_tblContact_Contactid",
                        column: x => x.Contactid,
                        principalTable: "tblContact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblOffers_tblProject_Projectid",
                        column: x => x.Projectid,
                        principalTable: "tblProject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblProjectStaff",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(80)", nullable: false),
                    UserId = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProjectStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProjectStaff_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblQuotation",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    offer_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    template_name = table.Column<string>(type: "varchar(150)", nullable: true),
                    template_url = table.Column<string>(type: "varchar(80)", nullable: true),
                    quotation_url = table.Column<string>(type: "varchar(80)", nullable: true),
                    version = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    Offerid = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblQuotation", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblQuotation_TblOffers_Offerid",
                        column: x => x.Offerid,
                        principalTable: "TblOffers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblService",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    erp_wbs_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    project_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    offer_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    contact_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    service_type = table.Column<string>(type: "varchar(80)", nullable: true),
                    service_location = table.Column<string>(type: "varchar(80)", nullable: true),
                    start_date = table.Column<string>(type: "varchar(80)", nullable: true),
                    end_date = table.Column<string>(type: "varchar(80)", nullable: true),
                    actual_hours = table.Column<int>(type: "int", nullable: false),
                    is_active = table.Column<string>(type: "varchar(80)", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    created_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    modified_at = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    modified_by = table.Column<string>(type: "varchar(50)", nullable: true),
                    Contactid = table.Column<string>(type: "varchar(50)", nullable: true),
                    Offerid = table.Column<string>(type: "varchar(80)", nullable: true),
                    Projectid = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblService", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblService_tblContact_Contactid",
                        column: x => x.Contactid,
                        principalTable: "tblContact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblService_TblOffers_Offerid",
                        column: x => x.Offerid,
                        principalTable: "TblOffers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblService_tblProject_Projectid",
                        column: x => x.Projectid,
                        principalTable: "tblProject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblServiceMachine",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar(80)", nullable: false),
                    service_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    machine_id = table.Column<string>(type: "varchar(80)", nullable: true),
                    Machineid = table.Column<string>(type: "varchar(80)", nullable: true),
                    Serviceid = table.Column<string>(type: "varchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblServiceMachine", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblServiceMachine_tblMachine_Machineid",
                        column: x => x.Machineid,
                        principalTable: "tblMachine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblServiceMachine_tblService_Serviceid",
                        column: x => x.Serviceid,
                        principalTable: "tblService",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCustomer_contactId",
                table: "tblCustomer",
                column: "contactId");

            migrationBuilder.CreateIndex(
                name: "IX_tblMachine_MasterMachineid",
                table: "tblMachine",
                column: "MasterMachineid");

            migrationBuilder.CreateIndex(
                name: "IX_TblOffers_Contactid",
                table: "TblOffers",
                column: "Contactid");

            migrationBuilder.CreateIndex(
                name: "IX_TblOffers_Projectid",
                table: "TblOffers",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_tblProjectStaff_UserId",
                table: "tblProjectStaff",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblQuotation_Offerid",
                table: "tblQuotation",
                column: "Offerid");

            migrationBuilder.CreateIndex(
                name: "IX_tblService_Contactid",
                table: "tblService",
                column: "Contactid");

            migrationBuilder.CreateIndex(
                name: "IX_tblService_Offerid",
                table: "tblService",
                column: "Offerid");

            migrationBuilder.CreateIndex(
                name: "IX_tblService_Projectid",
                table: "tblService",
                column: "Projectid");

            migrationBuilder.CreateIndex(
                name: "IX_tblServiceMachine_Machineid",
                table: "tblServiceMachine",
                column: "Machineid");

            migrationBuilder.CreateIndex(
                name: "IX_tblServiceMachine_Serviceid",
                table: "tblServiceMachine",
                column: "Serviceid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCompany");

            migrationBuilder.DropTable(
                name: "tblControllingArea");

            migrationBuilder.DropTable(
                name: "tblCustomer");

            migrationBuilder.DropTable(
                name: "tblErpContact");

            migrationBuilder.DropTable(
                name: "tblErpCustomer");

            migrationBuilder.DropTable(
                name: "tblProjectStaff");

            migrationBuilder.DropTable(
                name: "tblQuotation");

            migrationBuilder.DropTable(
                name: "tblServiceMachine");

            migrationBuilder.DropTable(
                name: "tblTenantCatalog");

            migrationBuilder.DropTable(
                name: "tblUser");

            migrationBuilder.DropTable(
                name: "tblMachine");

            migrationBuilder.DropTable(
                name: "tblService");

            migrationBuilder.DropTable(
                name: "tblMachinemaster");

            migrationBuilder.DropTable(
                name: "TblOffers");

            migrationBuilder.DropTable(
                name: "tblContact");

            migrationBuilder.DropTable(
                name: "tblProject");
        }
    }
}
