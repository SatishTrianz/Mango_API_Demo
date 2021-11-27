using Microsoft.EntityFrameworkCore;
using Schmersal_Models.Models;
using SSchmersal_Models.Models;

namespace Schmersal_Models.Sch_Entities
{
    public class Sch_Context : DbContext
    {
        public Sch_Context()
        {
        }

        public Sch_Context(DbContextOptions<Sch_Context> options)
                     : base(options)
        {
        }

        //public DbSet<Project> tblProject { get; set; }
        public virtual DbSet<TblCompany> TblCompanies { get; set; }
        public virtual DbSet<TblContact> TblContacts { get; set; }
        public virtual DbSet<TblControllingArea> TblControllingAreas { get; set; }
        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblErpContact> TblErpContacts { get; set; }
        public virtual DbSet<TblErpCustomer> TblErpCustomers { get; set; }
        public virtual DbSet<TblMachine> TblMachines { get; set; }
        public virtual DbSet<TblMasterMachine> TblMasterMachines { get; set; }
        public virtual DbSet<TblOffer> TblOffers { get; set; }
        public virtual DbSet<TblProject> TblProjects { get; set; }
        public virtual DbSet<TblProjectStaff> TblProjectStaffs { get; set; }
        public virtual DbSet<TblQuotation> TblQuotations { get; set; }
        public virtual DbSet<TblService> TblServices { get; set; }
        public virtual DbSet<TblServiceMachine> TblServiceMachines { get; set; }
        public virtual DbSet<TblTenantCatalog> TblTenantCatalogs { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:schdev.database.windows.net,1433;Initial Catalog=Sch_Dev;Persist Security Info=False;User ID=sch_dev001;Password=Connectme@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}
