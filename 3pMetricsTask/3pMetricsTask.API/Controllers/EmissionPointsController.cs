using _3pMetricsTask.Entities.Dtos.EmissionPointDtos;
using _3pMetricsTask.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace _3pMetricsTask.API.Controllers
{
    [ApiController]
    [Route("api/emissionPoints")]
    public class EmissionPointsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public EmissionPointsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet(Name = "GetAllEmissionPointsAsync")]
        public async Task<IActionResult> GetAllEmissionPointsAsync()
        {
            var result = await _manager.EmissionPointService.GetAllEmissionPointsAsync(false);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetEmissionPointByIdAsync")]
        public async Task<IActionResult> GetEmissionPointByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager.EmissionPointService.GetOneEmissionPointAsync(id, false);
            return Ok(result);
        }

        [HttpPost(Name = "CreateEmissionPointAsync")]
        public async Task<IActionResult> CreateEmissionPointAsync([FromBody] EmissionPointDtoForCreate emissionPointDtoForCreate)
        {
            var emissionPoint = await _manager.EmissionPointService.CreateOneEmissionPointAsync(emissionPointDtoForCreate);
            return StatusCode(201, emissionPoint);
        }

        [HttpDelete("{id:int}", Name = "DeleteEmissionPointAsync")]
        public async Task<IActionResult> DeleteEmissionPointAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.EmissionPointService.DeleteOneEmissionPointAsync(id, false);
            return Ok();
        }

        [HttpPut("{id:int}", Name = "UpdateEmissionPointAsync")]
        public async Task<IActionResult> UpdateEmissionPointAsync([FromRoute(Name = "id")] int id, [FromBody] EmissionPointDtoForUpdate emissionPointDtoForUpdate)
        {
            await _manager.EmissionPointService.UpdateOneEmissionPointAsync(id, emissionPointDtoForUpdate, false);
            return NoContent();
        }
    }
}
