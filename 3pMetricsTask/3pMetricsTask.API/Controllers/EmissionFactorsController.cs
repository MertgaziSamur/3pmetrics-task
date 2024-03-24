using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionFactorDtos;
using _3pMetricsTask.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace _3pMetricsTask.API.Controllers
{
    [ApiController]
    [Route("api/emissionFactors")]
    public class EmissionFactorsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public EmissionFactorsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet(Name = "GetAllEmissionFactorsAsync")]
        public async Task<IActionResult> GetAllEmissionFactorsAsync()
        {
            var result = await _manager.EmissionFactorService.GetAllEmissionFactorsAsync(false);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetEmissionFactorByIdAsync")]
        public async Task<IActionResult> GetEmissionFactorByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager.EmissionFactorService.GetOneEmissionFactorAsync(id, false);
            return Ok(result);
        }

        [HttpPost(Name = "CreateEmissionFactorAsync")]
        public async Task<IActionResult> CreateEmissionFactorAsync([FromBody] EmissionFactorDtoForCreate emissionFactorDtoForCreate)
        {
            var emissionFactor = await _manager.EmissionFactorService.CreateOneEmissionFactorAsync(emissionFactorDtoForCreate);
            return StatusCode(201, emissionFactor);
        }

        [HttpDelete("{id:int}", Name = "DeleteEmissionFactorAsync")]
        public async Task<IActionResult> DeleteEmissionFactorAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.EmissionFactorService.DeleteOneEmissionFactorAsync(id, false);
            return Ok();
        }

        [HttpPut("{id:int}", Name = "UpdateEmissionFactorAsync")]
        public async Task<IActionResult> UpdateEmissionFactorAsync([FromRoute(Name = "id")] int id, [FromBody] EmissionFactorDtoForUpdate emissionFactorDtoForUpdate)
        {
            await _manager.EmissionFactorService.UpdateOneEmissionFactorAsync(id, emissionFactorDtoForUpdate, false);
            return NoContent();
        }

    }
}
