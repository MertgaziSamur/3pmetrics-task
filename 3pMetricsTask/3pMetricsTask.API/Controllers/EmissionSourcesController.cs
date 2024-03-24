using _3pMetricsTask.Entities.Dtos.EmissionSourcesDtos;
using _3pMetricsTask.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace _3pMetricsTask.API.Controllers
{
    [ApiController]
    [Route("api/emissionSources")]
    public class EmissionSourcesController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public EmissionSourcesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet(Name = "GetAllEmissionSources")]
        public async Task<IActionResult> GetAllEmissionSources()
        {
            var result = await _manager.EmissionSourceService.GetAllEmissionSourcesAsync(false);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetEmissionSourceByIdAsync")]
        public async Task<IActionResult> GetEmissionSourceByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager.EmissionSourceService.GetOneEmissionSourceAsync(id, false);
            return Ok(result);
        }

        [HttpPost(Name = "CreateEmissionSourceAsync")]
        public async Task<IActionResult> CreateEmissionSourceAsync([FromBody] EmissionSourceDtoForCreate emissionSourceDtoForCreate)
        {
            var emissionSource = await _manager.EmissionSourceService.CreateOneEmissionSourceAsync(emissionSourceDtoForCreate);
            return StatusCode(201, emissionSource);
        }

        [HttpDelete("{id:int}", Name = "DeleteEmissionSourceAsync")]
        public async Task<IActionResult> DeleteEmissionSourceAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.EmissionSourceService.DeleteOneEmissionSourceAsync(id, false);
            return Ok();
        }

        [HttpPut("{id:int}", Name = "UpdateEmissionSourceAsync")]
        public async Task<IActionResult> UpdateEmissionSourceAsync([FromRoute(Name = "id")] int id, [FromBody] EmissionSourceDtoForUpdate emissionSourceDtoForUpdate)
        {
            await _manager.EmissionSourceService.UpdateOneEmissionSourceAsync(id, emissionSourceDtoForUpdate, false);
            return NoContent();
        }
    }
}
