using Mango_Services;
using Microsoft.EntityFrameworkCore;
using Schmersal_Models.ApiModels;
using Schmersal_Models.Models;
using Schmersal_Models.Sch_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryServices.Services
{
    public class ProjectService : RepositoryBase<TblProject>, IProjectService
    {
        private readonly Sch_Context _context;

        public ProjectService(Sch_Context context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Service for create new project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task<bool> CreateProject(ProjectApiModel project)
        {
            var isSuccess = false;
            //try
            //{
            //    var result = await _context.Database.ExecuteSqlRawAsync("exec usp_CreateProject  @Project_Name = {0}, @Erp_Project_Id = {1}, @Description = {2}, @Project_StartDate = {3}, @Project_EndDate = {4}, @Status = {5}, @Controlling_Id = {6}, @Tenant_ID = {7}, @Company_Id = {8}, @Customer_Id =  {9}, @Staff_Id = {10}, @Modified_At = {11}, @Modified_By = {12}, @Created_At = {13}, @Created_By = {14}, @Id = {15}",  project.Project_Name, project.Erp_Project_Id, project.Description, project.Start_Date, project.End_Date, project.Status, project.Controlling_Id, project.Tenant_Id, project.Company_Id, project.Customer_Id, project.Staff_Id, project.Modified_At, project.Modified_By, project.Created_At, project.Created_By, project.Id);
            //    if (result == 1)
            //    {
            //        isSuccess = true;
            //        return isSuccess;
            //    }
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
            return isSuccess;
        }

        /// <summary>
        /// Service for delete project
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteProject(string projectId)
        {
            try
            {
                var deleteProject = await _context.Database.ExecuteSqlRawAsync("usp_Deleteproject {0}", projectId);
                if (deleteProject == -1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        /// <summary>
        /// Repository Service to get All projects
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProjectApiModel>> GetAllProjects()
        {
            var result = await (from p in _context.TblProjects
                                join cus in _context.TblCustomers on p.customer_id equals cus.id
                                join con in _context.TblControllingAreas on p.controlling_id equals con.id
                                join pst in _context.TblProjectStaffs on p.staff_id equals pst.id
                                join u in _context.TblUsers on pst.user_id equals u.id
                                join cnt in _context.TblContacts on cus.contact_id equals cnt.contact_id
                                join tnc in _context.TblTenantCatalogs on p.tenant_id equals tnc.id
                                join comp in _context.TblCompanies on p.company_id equals comp.Id
                                select new ProjectApiModel
                                {
                                    Project_Id = p.id,
                                    Project_Name = p.project_name,
                                    Description = p.description,
                                    Start_Date = p.start_date,
                                    End_Date = p.end_date,
                                    Status = p.status,
                                    Controlling_Area = con.controlling_area,
                                    Region = tnc.region,
                                    Customer_Name = cus.customer_name,
                                    Comapny_Name = comp.company_name,
                                    Machnes = "40",
                                    User_Name = u.display_name
                                }).ToListAsync();
            return result;
        }

        /// <summary>
        /// Find project by Id
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<ProjectApiModel> GetprojectById(string projectId)
        {
            var result = await (from p in _context.TblProjects
                                join cus in _context.TblCustomers on p.customer_id equals cus.id
                                join con in _context.TblControllingAreas on p.controlling_id equals con.id
                                join pst in _context.TblProjectStaffs on p.staff_id equals pst.id
                                join u in _context.TblUsers on pst.user_id equals u.id
                                join cnt in _context.TblContacts on cus.contact_id equals cnt.contact_id
                                join tnc in _context.TblTenantCatalogs on p.tenant_id equals tnc.id
                                join comp in _context.TblCompanies on p.company_id equals comp.Id
                                select new ProjectApiModel
                                {
                                    Project_Id = p.id,
                                    Project_Name = p.project_name,
                                    Description = p.description,
                                    Start_Date = p.start_date,
                                    End_Date = p.end_date,
                                    Status = p.status,
                                    Controlling_Area = con.controlling_area,
                                    Region = tnc.region,
                                    Customer_Name = cus.customer_name,
                                    Comapny_Name = comp.company_name,
                                    Machnes = "40",
                                    User_Name = u.display_name
                                }).FirstOrDefaultAsync();
            return result;
        }

        /// <summary>
        /// Service to update project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task<bool> UpdateProject(TblProject project)
        {
            var isSuccess = false;
            //try
            //{
            //    var result = await _context.Database.ExecuteSqlRawAsync("exec usp_UpdateProject @Id = {0}, @Project_Name = {1}, @Erp_Project_Id = {2}, @Description = {3}, @Project_StartDate = {4}, @Project_EndDate = {5}, @Status = {6}, @Controlling_Id = {7}, @Tenant_ID = {8}, @Company_Id = {9}, @Customer_Id =  {10}, @Staff_Id = {11}, @Modified_At = {12}, @Modified_By = {13}", project.Id, project.Project_Name, project.Erp_Project_Id, project.Description, project.Start_Date, project.End_Date, project.Status, project.Controlling_Id, project.Tenant_Id, project.Company_Id, project.Customer_Id, project.Staff_Id, project.Modified_At, project.Modified_By);
            //    if (result == -1)
            //    {
            //        isSuccess = true;
            //        return isSuccess;
            //    }
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
            return isSuccess;
        }
    }
}
