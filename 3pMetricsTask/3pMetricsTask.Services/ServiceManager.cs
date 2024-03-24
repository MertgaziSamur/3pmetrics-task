using _3pMetricsTask.Repositories.Contracts;
using _3pMetricsTask.Services.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICatalogService> _catalogService;
        private readonly Lazy<IEmissionFactorService> _emissionFactorService;
        private readonly Lazy<IEmissionPointService> _emissionPointService;
        private readonly Lazy<IEmissionSourceService> _emissionSourceService;
        private readonly Lazy<IEmissionSourcesUnitService> _emissionSourcesUnitService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _catalogService = new Lazy<ICatalogService>(() => new CatalogManager(repositoryManager, mapper));
            _emissionFactorService = new Lazy<IEmissionFactorService>(() => new EmissionFactorManager(repositoryManager, mapper));
            _emissionPointService = new Lazy<IEmissionPointService>(() => new EmissionPointManager(repositoryManager, mapper));
            _emissionSourceService = new Lazy<IEmissionSourceService>(() => new EmissionSourceManager(repositoryManager, mapper));
            _emissionSourcesUnitService = new Lazy<IEmissionSourcesUnitService>(() => new EmissionSourcesUnitManager(repositoryManager, mapper));
        }

        public ICatalogService CatalogService => _catalogService.Value;

        public IEmissionFactorService EmissionFactorService => _emissionFactorService.Value;

        public IEmissionPointService EmissionPointService => _emissionPointService.Value;

        public IEmissionSourceService EmissionSourceService => _emissionSourceService.Value;

        public IEmissionSourcesUnitService EmissionSourcesUnitService => _emissionSourcesUnitService.Value;
    }
}
