using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICatalogRepository Catalog { get; }
        IEmissionFactorRepository EmissionFactor { get; }
        IEmissionPointRepository EmissionPoint { get; }
        IEmissionSourceRepository EmissionSource { get; }
        IEmissionSourcesUnitRepository EmissionSourcesUnit { get; }
        Task SaveAsync();
    }
}
