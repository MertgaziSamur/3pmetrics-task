using _3pMetricsTask.Entities.Dtos.EmissionSourcesUnitDtos;
using _3pMetricsTask.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace _3pMetricsTask.API.Controllers
{
    [ApiController]
    [Route("api/emissionSourcesUnits")]
    public class EmissionSourcesUnitsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public EmissionSourcesUnitsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet(Name = "GetAllEmissionSourcesUnitsAsync")]
        public async Task<IActionResult> GetAllEmissionSourcesUnitsAsync()
        {
            var result = await _manager.EmissionSourcesUnitService.GetAllEmissionSourcesUnitAsync(false);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetEmissionSourcesUnitByIdAsync")]
        public async Task<IActionResult> GetEmissionSourcesUnitByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager.EmissionSourcesUnitService.GetOneEmissionSourcesUnitAsync(id, false);
            return Ok(result);
        }

        [HttpPost(Name = "CreateEmissionSourcesUnitAsync")]
        public async Task<IActionResult> CreateEmissionSourcesUnitAsync([FromBody] EmissionSourcesUnitDtoForCreate emissionSourcesUnitDtoForCreate)
        {
            var emissionSourcesUnit = await _manager.EmissionSourcesUnitService.CreateOneEmissionSourcesUnitAsync(emissionSourcesUnitDtoForCreate);
            return StatusCode(201, emissionSourcesUnit);
        }

        [HttpDelete("{id:int}", Name = "DeleteEmissionSourcesUnitAsync")]
        public async Task<IActionResult> DeleteEmissionSourcesUnitAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.EmissionSourcesUnitService.DeleteOneEmissionSourcesUnitAsync(id, false);
            return Ok();
        }

        [HttpPut("{id:int}", Name = "UpdateEmissionSourcesUnitAsync")]
        public async Task<IActionResult> UpdateEmissionSourcesUnitAsync([FromRoute(Name = "id")] int id, [FromBody] EmissionSourcesUnitDtoForUpdate emissionSourcesUnitDtoForUpdate)
        {
            await _manager.EmissionSourcesUnitService.UpdateOneEmissionSourcesUnitAsync(id, emissionSourcesUnitDtoForUpdate, false);
            return NoContent();
        }
    }
}
