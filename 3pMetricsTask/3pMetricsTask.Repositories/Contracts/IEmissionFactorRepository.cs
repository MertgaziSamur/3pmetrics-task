using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.Contracts
{
    public interface IEmissionFactorRepository : IRepositoryBase<EmissionFactor>
    {
        Task<List<EmissionFactor>> GetAllEmissionFactorsAsync(bool trackChanges);
        Task<EmissionFactor> GetOneEmissionFactorByIdAsync(int id, bool trackChanges);
        void CreateOneEmissionFactor(EmissionFactor emissionFactor);
        void DeleteOneEmissionFactor(EmissionFactor emissionFactor);
        void UpdateOneEmissionFactor(EmissionFactor emissionFactor);
    }
}
