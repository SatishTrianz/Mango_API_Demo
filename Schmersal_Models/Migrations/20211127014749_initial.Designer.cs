﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schmersal_Models.Sch_Entities;

namespace Schmersal_Models.Migrations
{
    [DbContext(typeof(Sch_Context))]
    [Migration("20211127014749_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SSchmersal_Models.Models.TblOffer", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Contactid")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Projectid")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("contact_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("notes")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("project_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("quote_type")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("status")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.HasIndex("Contactid");

                    b.HasIndex("Projectid");

                    b.ToTable("TblOffers");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblCompany", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("company_code")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("company_name")
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("tblCompany");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblContact", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("department")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("display_name")
                        .HasColumnType("varchar(160)");

                    b.Property<string>("email_address")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("first_name")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("language")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("last_name")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("title")
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.ToTable("tblContact");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblControllingArea", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("controlling_area")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("controlling_area_code")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("tblControllingArea");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblCustomer", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("city")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("contactId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("countryCode")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("customer_name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("erp_customer_id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("language")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("street")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("zipcode")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("contactId");

                    b.ToTable("tblCustomer");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblErpContact", b =>
                {
                    b.Property<string>("erp_eontact_id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("customer_id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("department")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("display_name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("email_address")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("first_name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("language")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("last_name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("title")
                        .HasColumnType("varchar(50)");

                    b.HasKey("erp_eontact_id");

                    b.ToTable("tblErpContact");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblErpCustomer", b =>
                {
                    b.Property<string>("erp_customer_id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("city")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("company_code")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("company_name")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("controlling_area")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("controlling_area_code")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("country_code")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("customer_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("customer_name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("phone_number")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("street")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("zipcode")
                        .HasColumnType("varchar(50)");

                    b.HasKey("erp_customer_id");

                    b.ToTable("tblErpCustomer");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblMachine", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("MasterMachineid")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("asset_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("estimated_hours")
                        .HasColumnType("int");

                    b.Property<byte[]>("machine_description")
                        .HasColumnType("varbinary(150)");

                    b.Property<string>("machine_name")
                        .HasColumnType("varchar(160)");

                    b.Property<string>("master_machine_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("serial_number")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.HasIndex("MasterMachineid");

                    b.ToTable("tblMachine");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblMasterMachine", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("machine_name")
                        .HasColumnType("varchar(160)");

                    b.Property<string>("machine_type")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("manufacturer")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("tblMachinemaster");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblProject", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("company_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("controlling_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("customer_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("description")
                        .HasColumnType("varchar(160)");

                    b.Property<DateTime?>("end_date")
                        .HasColumnType("datetime");

                    b.Property<string>("erp_project_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("project_name")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("staff_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime");

                    b.Property<string>("status")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("tenant_id")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.ToTable("tblProject");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblProjectStaff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("tblProjectStaff");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblQuotation", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Offerid")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("offer_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("quotation_url")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("template_name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("template_url")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("version")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.HasIndex("Offerid");

                    b.ToTable("tblQuotation");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblService", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Contactid")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Offerid")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Projectid")
                        .HasColumnType("varchar(80)");

                    b.Property<int>("actual_hours")
                        .HasColumnType("int");

                    b.Property<string>("contact_id")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("created_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("created_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("end_date")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("erp_wbs_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("is_active")
                        .HasColumnType("varchar(80)");

                    b.Property<DateTimeOffset>("modified_at")
                        .HasColumnType("datetimeoffset(7)");

                    b.Property<string>("modified_by")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("offer_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("project_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("service_location")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("service_type")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("start_date")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.HasIndex("Contactid");

                    b.HasIndex("Offerid");

                    b.HasIndex("Projectid");

                    b.ToTable("tblService");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblServiceMachine", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Machineid")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Serviceid")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("machine_id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("service_id")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.HasIndex("Machineid");

                    b.HasIndex("Serviceid");

                    b.ToTable("tblServiceMachine");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblTenantCatalog", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("client_name")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("country")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("language")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("region")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.ToTable("tblTenantCatalog");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblUser", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("display_name")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("email_address")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("first_name")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("last_name")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("login_name")
                        .HasColumnType("varchar(80)");

                    b.HasKey("id");

                    b.ToTable("tblUser");
                });

            modelBuilder.Entity("SSchmersal_Models.Models.TblOffer", b =>
                {
                    b.HasOne("Schmersal_Models.Models.TblContact", "Contact")
                        .WithMany("TblOffers")
                        .HasForeignKey("Contactid");

                    b.HasOne("Schmersal_Models.Models.TblProject", "Project")
                        .WithMany("TblOffers")
                        .HasForeignKey("Projectid");

                    b.Navigation("Contact");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblCustomer", b =>
                {
                    b.HasOne("Schmersal_Models.Models.TblContact", "Contact")
                        .WithMany("TblCustomers")
                        .HasForeignKey("contactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblMachine", b =>
                {
                    b.HasOne("Schmersal_Models.Models.TblMasterMachine", "MasterMachine")
                        .WithMany("TblMachines")
                        .HasForeignKey("MasterMachineid");

                    b.Navigation("MasterMachine");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblProjectStaff", b =>
                {
                    b.HasOne("Schmersal_Models.Models.TblUser", "User")
                        .WithMany("TblProjectStaffs")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblQuotation", b =>
                {
                    b.HasOne("SSchmersal_Models.Models.TblOffer", "Offer")
                        .WithMany("TblQuotations")
                        .HasForeignKey("Offerid");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblService", b =>
                {
                    b.HasOne("Schmersal_Models.Models.TblContact", "Contact")
                        .WithMany("TblServices")
                        .HasForeignKey("Contactid");

                    b.HasOne("SSchmersal_Models.Models.TblOffer", "Offer")
                        .WithMany("TblServices")
                        .HasForeignKey("Offerid");

                    b.HasOne("Schmersal_Models.Models.TblProject", "Project")
                        .WithMany("TblServices")
                        .HasForeignKey("Projectid");

                    b.Navigation("Contact");

                    b.Navigation("Offer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblServiceMachine", b =>
                {
                    b.HasOne("Schmersal_Models.Models.TblMachine", "Machine")
                        .WithMany("TblServiceMachines")
                        .HasForeignKey("Machineid");

                    b.HasOne("Schmersal_Models.Models.TblService", "Service")
                        .WithMany("TblServiceMachines")
                        .HasForeignKey("Serviceid");

                    b.Navigation("Machine");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("SSchmersal_Models.Models.TblOffer", b =>
                {
                    b.Navigation("TblQuotations");

                    b.Navigation("TblServices");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblContact", b =>
                {
                    b.Navigation("TblCustomers");

                    b.Navigation("TblOffers");

                    b.Navigation("TblServices");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblMachine", b =>
                {
                    b.Navigation("TblServiceMachines");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblMasterMachine", b =>
                {
                    b.Navigation("TblMachines");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblProject", b =>
                {
                    b.Navigation("TblOffers");

                    b.Navigation("TblServices");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblService", b =>
                {
                    b.Navigation("TblServiceMachines");
                });

            modelBuilder.Entity("Schmersal_Models.Models.TblUser", b =>
                {
                    b.Navigation("TblProjectStaffs");
                });
#pragma warning restore 612, 618
        }
    }
}
