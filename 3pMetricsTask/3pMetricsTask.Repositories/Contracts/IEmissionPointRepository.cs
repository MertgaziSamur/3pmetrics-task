using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.Contracts
{
    public interface IEmissionPointRepository : IRepositoryBase<EmissionPoint>
    {
        Task<List<EmissionPoint>> GetAllEmissionPointsAsync(bool trackChanges);
        Task<EmissionPoint> GetOneEmissionPointByIdAsync(int id, bool trackChanges);
        void CreateOneEmissionPoint(EmissionPoint emissionPoint);
        void DeleteOneEmissionPoint(EmissionPoint emissionPoint);
        void UpdateOneEmissionPoint(EmissionPoint emissionPoint);   
    }
}
