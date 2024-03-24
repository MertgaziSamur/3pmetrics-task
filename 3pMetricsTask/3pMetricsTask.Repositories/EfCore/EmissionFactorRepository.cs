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
    public class EmissionFactorRepository : RepositoryBase<EmissionFactor>, IEmissionFactorRepository
    {
        public EmissionFactorRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneEmissionFactor(EmissionFactor emissionFactor) => Create(emissionFactor);

        public void DeleteOneEmissionFactor(EmissionFactor emissionFactor) => Delete(emissionFactor);

        public async Task<List<EmissionFactor>> GetAllEmissionFactorsAsync(bool trackChanges) => await FindAll(trackChanges).OrderBy(ef => ef.Id).ToListAsync();

        public async Task<EmissionFactor> GetOneEmissionFactorByIdAsync(int id, bool trackChanges) => await FindByCondition(ef => ef.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public void UpdateOneEmissionFactor(EmissionFactor emissionFactor) => Update(emissionFactor);

    }
}
