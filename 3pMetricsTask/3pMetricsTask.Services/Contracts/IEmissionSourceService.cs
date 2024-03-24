using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionSourcesDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Contracts
{
    public interface IEmissionSourceService
    {
        Task<List<EmissionSourceDto>> GetAllEmissionSourcesAsync(bool trackChanges);
        Task<EmissionSourceDto> GetOneEmissionSourceAsync(int id, bool trackChanges);
        Task<EmissionSourceDto> CreateOneEmissionSourceAsync(EmissionSourceDtoForCreate emissionSourceDtoForCreate);
        Task UpdateOneEmissionSourceAsync(int id, EmissionSourceDtoForUpdate emissionSourceDtoForUpdate, bool trackChanges);
        Task DeleteOneEmissionSourceAsync(int id, bool trackChanges);
    }
}
