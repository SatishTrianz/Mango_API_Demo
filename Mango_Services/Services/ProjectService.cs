using Mango_Services;
using Microsoft.EntityFrameworkCore;
using Schmersal_Models.Models;
using Schmersal_Models.Sch_Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServices.Services
{
   public class ProjectService: RepositoryBase<Project>, IProjectService
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
        public async Task<bool> CreateProject(Project project)
        {
            var isSuccess = false;
            try
            {
                var result = await _context.Database.ExecuteSqlRawAsync("exec usp_CreateProject  @Project_Name = {0}, @Erp_Project_Id = {1}, @Description = {2}, @Project_StartDate = {3}, @Project_EndDate = {4}, @Status = {5}, @Controlling_Id = {6}, @Tenant_ID = {7}, @Company_Id = {8}, @Customer_Id =  {9}, @Staff_Id = {10}, @Modified_At = {11}, @Modified_By = {12}, @Created_At = {13}, @Created_By = {14}, @Id = {15}",  project.Project_Name, project.Erp_Project_Id, project.Description, project.Start_Date, project.End_Date, project.Status, project.Controlling_Id, project.Tenant_Id, project.Company_Id, project.Customer_Id, project.Staff_Id, project.Modified_At, project.Modified_By, project.Created_At, project.Created_By, project.Id);
                if (result == 1)
                {
                    isSuccess = true;
                    return isSuccess;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
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
        public async Task<List<Project>> GetAllProjects()
        {
            return await _context.tblProject.FromSqlRaw<Project>($"usp_SchGetAllProjects").ToListAsync();
        }

        /// <summary>
        /// Find project by Id
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<Project> GetprojectById(string projectId)
        {
            return await _context.tblProject.FirstOrDefaultAsync(prj => prj.Id == projectId);
        }

        /// <summary>
        /// Service to update project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task<bool> UpdateProject(Project project)
        {
            var isSuccess = false;
            try
            {
                var result = await _context.Database.ExecuteSqlRawAsync("exec usp_UpdateProject @Id = {0}, @Project_Name = {1}, @Erp_Project_Id = {2}, @Description = {3}, @Project_StartDate = {4}, @Project_EndDate = {5}, @Status = {6}, @Controlling_Id = {7}, @Tenant_ID = {8}, @Company_Id = {9}, @Customer_Id =  {10}, @Staff_Id = {11}, @Modified_At = {12}, @Modified_By = {13}", project.Id, project.Project_Name, project.Erp_Project_Id, project.Description, project.Start_Date, project.End_Date, project.Status, project.Controlling_Id, project.Tenant_Id, project.Company_Id, project.Customer_Id, project.Staff_Id, project.Modified_At, project.Modified_By);
                if (result == -1)
                {
                    isSuccess = true;
                    return isSuccess;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return isSuccess;
        }
    }
}
