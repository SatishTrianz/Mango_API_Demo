using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryServices.Services;
using Schmersal_Models.ApiModels;
using Schmersal_Models.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Controllers
{
    [Route("api/projectservice")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public readonly IProjectService _repositoryService;
        public ProjectController(IProjectService repositoryService)
        {
            _repositoryService = repositoryService;
        }

        /// <summary>
        /// Get All available project records
        /// </summary>       
        [Route("get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
        {
            var result = await _repositoryService.GetAllProjects();
            if (!result.Any())
            {
                return NotFound("No Records Found");
            }
            return Ok(new JsonResult(result));
        }

        /// <summary>
        /// Create New project 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        [Route("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [HttpPost]
        public async Task<IActionResult> CeateNewProject([FromBody] ProjectApiModel project)
        {
            var result = await _repositoryService.CreateProject(project);
            if (result == false)
            {
                return BadRequest("Project not been created");
            }
            return Ok(new JsonResult("Project has been created"));
        }

        /// <summary>
        /// Delete selected project
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [Route("delete/{projectId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProject(string projectId)
        {
            var message = string.Empty;
            var result = await _repositoryService.DeleteProject(projectId);
            if (result == true)
            {
                message = "Project has been deleted";
            }
            else
            {
                message = "No project found";
            }
            return Ok(new JsonResult(message));
        }

        /// <summary>
        /// Update selected project
        /// </summary>
        /// <param name="schProject"></param>
        /// <returns></returns>
        [Route("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [HttpPut]
        public async Task<IActionResult> Updateproject([FromBody] TblProject schProject)
        {
            string message = string.Empty;
            var result = await _repositoryService.UpdateProject(schProject);
            if (result == true)
            {
                message = "Project has been updated";
            }
            else
            {
                message = "No project found";
            }
            return Ok(new JsonResult(message));
        }

        /// <summary>
        /// Find project by Id
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        [Route("getprojectbyid/{projectId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        [HttpGet]
        public async Task<IActionResult> GetProjectById(string projectId)
        {
            var result = await _repositoryService.GetprojectById(projectId);

            if (result == null)
            {
                return NotFound("No Project Found");
            }
            return Ok(new JsonResult(result));
        }
    }
}
