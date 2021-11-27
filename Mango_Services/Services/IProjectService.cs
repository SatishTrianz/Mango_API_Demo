using Mango_Services;
using Schmersal_Models.ApiModels;
using Schmersal_Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServices.Services
{
   public interface IProjectService: IRepositoryBase<TblProject>
    {
        Task<List<ProjectApiModel>> GetAllProjects();
        Task<bool> CreateProject(ProjectApiModel project);
        Task<bool> UpdateProject(TblProject project);
        Task<bool> DeleteProject(string projectId);
        Task<ProjectApiModel> GetprojectById(string projectId);
    }
}
