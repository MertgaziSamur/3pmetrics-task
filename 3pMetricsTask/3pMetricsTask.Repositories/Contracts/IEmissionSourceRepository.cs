using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.Contracts
{
    public interface IEmissionSourceRepository : IRepositoryBase<EmissionSource>
    {
        Task<List<EmissionSource>> GetAllEmissionSourcesAsync(bool trackChanges);
        Task<EmissionSource> GetOneEmissionSourceByIdAsync(int id, bool trackChanges);
        void CreateOneEmissionSource(EmissionSource emissionSource);
        void UpdateOneEmissionSource(EmissionSource emissionSource);
        void DeleteOneEmissionSource(EmissionSource emissionSource);
    }
}
