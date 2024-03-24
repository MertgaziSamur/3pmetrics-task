using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.Contracts
{
    public interface ICatalogRepository : IRepositoryBase<Catalog>
    {
        Task<List<Catalog>> GetAllCatalogsAsync(bool trackChanges);
        Task<Catalog> GetOneCatalogByIdAsync(int id, bool trackChanges);
        void CreateOneCatalog(Catalog catalog);
        void UpdateOneCatalog(Catalog catalog);
        void DeleteOneCatalog(Catalog catalog);

    }
}
