using _3pMetricsTask.Entities.Entities;
using _3pMetricsTask.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.EfCore
{
    public class EmissionSourcesUnitRepository : RepositoryBase<EmissionSourcesUnit>, IEmissionSourcesUnitRepository
    {
        public EmissionSourcesUnitRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneEmissionSourcesUnit(EmissionSourcesUnit emissionSourcesUnit) => Create(emissionSourcesUnit);


        public void DeleteOneEmissionSourcesUnit(EmissionSourcesUnit emissionSourcesUnit) => Delete(emissionSourcesUnit);

        public async Task<List<EmissionSourcesUnit>> GetAllEmissionSourcesUnitsAsync(bool trackChanges) => await FindAll(trackChanges).OrderBy(esu => esu.Id).ToListAsync();


        public async Task<EmissionSourcesUnit> GetOneEmissionSourcesUnitByIdAsync(int id, bool trackChanges) => await FindByCondition(esu => esu.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public void UpdateOneEmissionSourcesUnit(EmissionSourcesUnit emissionSourcesUnit) => Update(emissionSourcesUnit);

    }
}
