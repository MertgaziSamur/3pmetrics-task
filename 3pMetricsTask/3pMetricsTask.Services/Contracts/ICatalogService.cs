using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Contracts
{
    public interface ICatalogService
    {
        Task<List<CatalogDto>> GetAllCatalogsAsync(bool trackChanges);
        Task<CatalogDto> GetOneCatalogAsync(int id, bool trackChanges);
        Task<CatalogDto> CreateOneCatalogAsync(CatalogDtoForCreate catalogDtoForCreate);
        Task UpdateOneCatalogAsync(int id, CatalogDtoForUpdate catalogDtoForUpdate, bool trackChanges);
        Task DeleteOneCatalogAsync(int id, bool trackChanges);
    }
}
