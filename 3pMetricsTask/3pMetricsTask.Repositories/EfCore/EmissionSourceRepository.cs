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
    public class EmissionSourceRepository : RepositoryBase<EmissionSource>, IEmissionSourceRepository
    {
        public EmissionSourceRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneEmissionSource(EmissionSource emissionSource) => Create(emissionSource);


        public void DeleteOneEmissionSource(EmissionSource emissionSource) => Delete(emissionSource);


        public async Task<List<EmissionSource>> GetAllEmissionSourcesAsync(bool trackChanges) => await FindAll(trackChanges).OrderBy(es => es.Id).ToListAsync();


        public async Task<EmissionSource> GetOneEmissionSourceByIdAsync(int id, bool trackChanges) => await FindByCondition(es => es.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public void UpdateOneEmissionSource(EmissionSource emissionSource) => Update(emissionSource);

    }
}
