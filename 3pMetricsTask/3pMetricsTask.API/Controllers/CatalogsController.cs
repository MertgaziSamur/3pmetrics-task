using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace _3pMetricsTask.API.Controllers
{
    [ApiController]
    [Route("api/catalogs")]
    public class CatalogsController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public CatalogsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet(Name = "GetAllCatalogsAsync")]
        public async Task<IActionResult> GetAllCatalogsAsync()
        {
            var result = await _manager.CatalogService.GetAllCatalogsAsync(false);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetCatalogByIdAsync")]
        public async Task<IActionResult> GetCatalogByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager.CatalogService.GetOneCatalogAsync(id, false);
            return Ok(result);
        }

        [HttpPost(Name = "CreateCatalogAsync")]
        public async Task<IActionResult> CreateCatalogAsync([FromBody] CatalogDtoForCreate catalogDtoForCreate)
        {
            var catalog = await _manager.CatalogService.CreateOneCatalogAsync(catalogDtoForCreate);
            return StatusCode(201, catalog);
        }

        [HttpDelete("{id:int}", Name = "DeleteCatalogAsync")]
        public async Task<IActionResult> DeleteCatalogAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.CatalogService.DeleteOneCatalogAsync(id, false);
            return Ok();
        }

        [HttpPut("{id:int}", Name = "UpdateCatalogAsync")]
        public async Task<IActionResult> UpdateCatalogAsync([FromRoute(Name = "id")] int id, [FromBody] CatalogDtoForUpdate catalogDtoForUpdate)
        {
            await _manager.CatalogService.UpdateOneCatalogAsync(id, catalogDtoForUpdate, false);
            return NoContent();
        }
    }
}
