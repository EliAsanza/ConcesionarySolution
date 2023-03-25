using ConcesionarySolution.Application.Services;
using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Concesionary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RevisionController: Controller
    {
        //Inyrccion de dependencias
        private readonly IRevisionService _revisionService;
        public RevisionController(IRevisionService revisionService)
        { 
            _revisionService = revisionService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllRevisions()
        {
            try
            {
                return Ok(_revisionService.GetAllRevisionsAsync());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNewRevision(Revision request)
        {
            return Ok(_revisionService.AddRevisionAsync(request));
        }

        [HttpPut]
        [Route("UpdateRevision/{revisionId:int}")]
        public async Task<IActionResult> UpdateRevision(int revisionId, Revision request)
        {
            return Ok(_revisionService.UpdateRevisionAsync(revisionId, request));
        }

        [HttpDelete]
        [Route("DeleteRevisionById/{RevisionId:int}")]
        public async Task<IActionResult> DeleteRevisionById(int revisionId)
        {
            return Ok(_revisionService.DeleteRevisionAsync(revisionId));
        }

    }
}
