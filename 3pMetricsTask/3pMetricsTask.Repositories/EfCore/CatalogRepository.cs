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
    public class CatalogRepository : RepositoryBase<Catalog>, ICatalogRepository
    {
        public CatalogRepository(RepositoryContext context) : base(context)
        {

        }

        public void CreateOneCatalog(Catalog catalog) => Create(catalog);


        public void DeleteOneCatalog(Catalog catalog) => Delete(catalog);


        public async Task<List<Catalog>> GetAllCatalogsAsync(bool trackChanges) => await FindAll(trackChanges).OrderBy(c => c.Id).ToListAsync();


        public async Task<Catalog> GetOneCatalogByIdAsync(int id, bool trackChanges) => await FindByCondition(c => c.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        public void UpdateOneCatalog(Catalog catalog) => Update(catalog);

    }
}
