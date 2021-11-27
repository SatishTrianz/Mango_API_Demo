using Schmersal_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schmersal_Models.ApiModels
{
    public class ProjectApiModel
    {
        public string Project_Id { get; set; }
        public string Erp_Project_Id { get; set; }

        public string Project_Name { get; set; }

        public string Description { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        public string Status { get; set; }

        public string Controlling_Area { get; set; }

        public string Region { get; set; }

        public string Comapny_Name { get; set; }

        public string Customer_Name { get; set; }

        public string User_Name { get; set; }
        public string Machnes { get; set; }


        //public static explicit operator ProjectApiModel(Project project) => new ProjectApiModel
        //{
        //    Id = project.Id,
        //    Erp_Project_Id = project.Erp_Project_Id,
        //    Project_Name = project.Project_Name,
        //    Description = project.Description,
        //    Start_Date = project.Start_Date,
        //    End_Date = project.End_Date,
        //    Status = project.Status,
        //    Controlling_Id = project.Controlling_Id,
        //    Tenant_Id = project.Tenant_Id,
        //    Company_Id = project.Company_Id,
        //    Customer_Id = project.Customer_Id,
        //    Staff_Id = project.Staff_Id,
        //    Created_At = project.Created_At,
        //    Created_By = project.Created_By,
        //    Modified_At = project.Modified_At,
        //    Modified_By = project.Modified_By
        //};
    }
}
