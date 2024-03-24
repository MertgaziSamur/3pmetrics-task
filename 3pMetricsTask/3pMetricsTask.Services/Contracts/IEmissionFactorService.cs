using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionFactorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Contracts
{
    public interface IEmissionFactorService
    {
        Task<List<EmissionFactorDto>> GetAllEmissionFactorsAsync(bool trackChanges);
        Task<EmissionFactorDto> GetOneEmissionFactorAsync(int id, bool trackChanges);
        Task<EmissionFactorDto> CreateOneEmissionFactorAsync(EmissionFactorDtoForCreate emissionFactorDtoForCreate);
        Task UpdateOneEmissionFactorAsync(int id, EmissionFactorDtoForUpdate emissionFactorDtoForUpdate, bool trackChanges);
        Task DeleteOneEmissionFactorAsync(int id, bool trackChanges);
    }
}
