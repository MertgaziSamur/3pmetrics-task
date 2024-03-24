using _3pMetricsTask.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.EfCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<ICatalogRepository> _catalogRepository;
        private readonly Lazy<IEmissionFactorRepository> _emissionFactorRepository;
        private readonly Lazy<IEmissionPointRepository> _emissionPointRepository;
        private readonly Lazy<IEmissionSourceRepository> _emissionSourceRepository;
        private readonly Lazy<IEmissionSourcesUnitRepository> _emissionSourcesUnitRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _catalogRepository = new Lazy<ICatalogRepository>(() => new CatalogRepository(_context));
            _emissionFactorRepository = new Lazy<IEmissionFactorRepository>(() => new EmissionFactorRepository(_context));
            _emissionPointRepository = new Lazy<IEmissionPointRepository>(() => new EmissionPointRepository(_context));
            _emissionSourceRepository = new Lazy<IEmissionSourceRepository>(() => new EmissionSourceRepository(_context));
            _emissionSourcesUnitRepository = new Lazy<IEmissionSourcesUnitRepository>(() => new EmissionSourcesUnitRepository(_context));
        }
        public ICatalogRepository Catalog => _catalogRepository.Value;

        public IEmissionFactorRepository EmissionFactor => _emissionFactorRepository.Value;

        public IEmissionPointRepository EmissionPoint => _emissionPointRepository.Value;

        public IEmissionSourceRepository EmissionSource => _emissionSourceRepository.Value;

        public IEmissionSourcesUnitRepository EmissionSourcesUnit => _emissionSourcesUnitRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
