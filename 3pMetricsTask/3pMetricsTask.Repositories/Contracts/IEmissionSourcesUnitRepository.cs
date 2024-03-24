using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.Contracts
{
    public interface IEmissionSourcesUnitRepository : IRepositoryBase<EmissionSourcesUnit>
    {
        Task<List<EmissionSourcesUnit>> GetAllEmissionSourcesUnitsAsync(bool trackChanges);
        Task<EmissionSourcesUnit> GetOneEmissionSourcesUnitByIdAsync(int id, bool trackChanges);
        void CreateOneEmissionSourcesUnit(EmissionSourcesUnit emissionSourcesUnit);
        void UpdateOneEmissionSourcesUnit(EmissionSourcesUnit emissionSourcesUnit);
        void DeleteOneEmissionSourcesUnit(EmissionSourcesUnit emissionSourcesUnit);
    }
}
