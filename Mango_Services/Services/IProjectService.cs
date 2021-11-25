using Mango_Services;
using Schmersal_Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServices.Services
{
   public interface IProjectService: IRepositoryBase<Project>
    {
        Task<List<Project>> GetAllProjects();
        Task<bool> CreateProject(Project project);
        Task<bool> UpdateProject(Project project);
        Task<bool> DeleteProject(string projectId);
        Task<Project> GetprojectById(string projectId);
    }
}
