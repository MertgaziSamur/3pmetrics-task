using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionSourcesUnitDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Contracts
{
    public interface IEmissionSourcesUnitService
    {
        Task<List<EmissionSourcesUnitDto>> GetAllEmissionSourcesUnitAsync(bool trackChanges);
        Task<EmissionSourcesUnitDto> GetOneEmissionSourcesUnitAsync(int id, bool trackChanges);
        Task<EmissionSourcesUnitDto> CreateOneEmissionSourcesUnitAsync(EmissionSourcesUnitDtoForCreate emissionSourcesUnitDtoForCreate);
        Task UpdateOneEmissionSourcesUnitAsync(int id, EmissionSourcesUnitDtoForUpdate emissionSourcesUnitDtoForUpdate, bool trackChanges);
        Task DeleteOneEmissionSourcesUnitAsync(int id, bool trackChanges);
    }
}
