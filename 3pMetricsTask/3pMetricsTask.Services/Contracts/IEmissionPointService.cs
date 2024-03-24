using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionPointDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Contracts
{
    public interface IEmissionPointService
    {
        Task<List<EmissionPointDto>> GetAllEmissionPointsAsync(bool trackChanges);
        Task<EmissionPointDto> GetOneEmissionPointAsync(int id, bool trackChanges);
        Task<EmissionPointDto> CreateOneEmissionPointAsync(EmissionPointDtoForCreate emissionPointDtoForCreate);
        Task UpdateOneEmissionPointAsync(int id, EmissionPointDtoForUpdate emissionPointDtoForUpdate, bool trackChanges);
        Task DeleteOneEmissionPointAsync(int id, bool trackChanges);
    }
}
