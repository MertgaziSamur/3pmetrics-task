using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Contracts
{
    public interface IServiceManager
    {
        ICatalogService CatalogService { get; }
        IEmissionFactorService EmissionFactorService { get; }
        IEmissionPointService EmissionPointService { get; }
        IEmissionSourceService EmissionSourceService { get; }
        IEmissionSourcesUnitService EmissionSourcesUnitService { get; }

    }
}
