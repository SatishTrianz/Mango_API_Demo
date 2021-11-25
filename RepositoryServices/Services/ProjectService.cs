using Microsoft.EntityFrameworkCore;
using Schmersal_Models.Models;
using Schmersal_Models.Sch_Entities;
using System;
using System.Collections.Generic;
using System.Text;
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
        /// Repository Service for create new project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task<bool> CreateProject(Project project)
        {
            var isSuccess = false;
            try
            {
                //var result = await _context.Database.ExecuteSqlRawAsync("exec usp_CreateProject @Project_Code = {0},@Project_Description = {1},@Project_Notes = {2},@Customer_ID = {3},@Project_StartDate = {4},@Project_EndDate = {5},@ControllingArea_Id = {6},@Tenant_ID = {7},@Project_Cost = {8},@Working_Hours =  {9},@IsDeleted = {10},@DeletedReason = {11}", project.ProjectCode, project.ProjectDescription, project.ProjectNotes, project.CustomerId, project.ProjectStartDate, project.ProjectEndDate, project.ControllingArea, project.TenantId, project.ProjectCost, project.WorkingHours, project.IsDeleted, project.DeletedReason);
                //if (result == 1)
                //{
                //    isSuccess = true;
                //    return isSuccess;
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
            return isSuccess;
        }

        /// <summary>
        /// Repository Service for delete project
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
        /// Repository to update project
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public async Task<bool> UpdateProject(Project project)
        {
            var isSuccess = false;
            try
            {
                //var result = await _context.Database.ExecuteSqlRawAsync("exec usp_UpdateProject @Project_Id = {0}, @Project_Code = {1},@Project_Description = {2},@Project_Notes = {3},@Customer_ID = {4},@Project_StartDate = {5},@Project_EndDate = {6},@ControllingArea_Id = {7},@Tenant_ID = {8},@Project_Cost = {9},@Working_Hours =  {10},@IsDeleted = {11},@DeletedReason = {12}", project.Id, project.ProjectCode, project.ProjectDescription, project.ProjectNotes, project.CustomerId, project.ProjectStartDate, project.ProjectEndDate, project.ControllingArea, project.TenantId, project.ProjectCost, project.WorkingHours, project.IsDeleted, project.DeletedReason);
                //if (result == -1)
                //{
                //    isSuccess = true;
                //    return isSuccess;
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
            return isSuccess;
        }
    }
}
