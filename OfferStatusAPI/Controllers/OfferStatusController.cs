using Mango_Services.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OfferStatusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferStatusController : ControllerBase
    {

        public readonly IOfferStatusService _repositoryService;
        public OfferStatusController(IOfferStatusService offerStatusService)
        {
            _repositoryService = offerStatusService;
        }

        // GET: api/<OfferStatusController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            var result = await _repositoryService.GetAllOfferStatus();
            if (!result.Any())
            {
                return NotFound("No Records Found");
            }
            return Ok(new JsonResult(result));
        }
        [HttpGet]
        public async Task<ActionResult> GetOfferDetailsById(string offerId)
        {

            var result = await _repositoryService.GetAllOfferStatus();
            if (!result.Any())
            {
                return NotFound("No Records Found");
            }
            return Ok(new JsonResult(result));
        }

        //[HttpPost]
        //public async Task<ActionResult> Post([FromBody] OfferStatus offerStatus)
        //{
        //    var result = await _repositoryService.CreateOfferStatus(offerStatus);
        //    if (!result.Any())
        //    {
        //        return NotFound("No Records Found");
        //    }
        //    return Ok(new JsonResult(result));
        //}


        //[HttpPut]
        //public async Task<ActionResult> Put([FromBody] OfferStatus offerStatus)
        //{
        //    var result = await _repositoryService.UpdateOfferStatus(offerStatus);
        //    if (!result.Any())
        //    {
        //        return NotFound("No Records Found");
        //    }
        //    return Ok(new JsonResult(result));
        //}


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repositoryService.DeleteOfferStatus(id);
            if (!result.Any())
            {
                return NotFound("No Records Found");
            }
            return Ok(new JsonResult(result));
        }
    }
}
