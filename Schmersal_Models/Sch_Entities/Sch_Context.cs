using Microsoft.EntityFrameworkCore;
using Schmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schmersal_Models.Sch_Entities
{
    public class Sch_Context: DbContext
    {
        public Sch_Context()
        {
        }

        public Sch_Context(DbContextOptions<Sch_Context> options)
                     : base(options)
        {
        }

        public DbSet<Project> tblProject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:schdev.database.windows.net,1433;Initial Catalog=Sch_Dev;Persist Security Info=False;User ID=sch_dev001;Password=Connectme@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60;");
        }
    }
}
