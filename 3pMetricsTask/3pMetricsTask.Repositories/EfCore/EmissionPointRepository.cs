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
    public class EmissionPointRepository : RepositoryBase<EmissionPoint>, IEmissionPointRepository
    {
        public EmissionPointRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateOneEmissionPoint(EmissionPoint emissionPoint) => Create(emissionPoint);


        public void DeleteOneEmissionPoint(EmissionPoint emissionPoint) => Delete(emissionPoint);


        public async Task<List<EmissionPoint>> GetAllEmissionPointsAsync(bool trackChanges) => await FindAll(trackChanges).OrderBy(ep => ep.Id).ToListAsync();


        public async Task<EmissionPoint> GetOneEmissionPointByIdAsync(int id, bool trackChanges) => await FindByCondition(ep => ep.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public void UpdateOneEmissionPoint(EmissionPoint emissionPoint) => Update(emissionPoint);

    }
}
