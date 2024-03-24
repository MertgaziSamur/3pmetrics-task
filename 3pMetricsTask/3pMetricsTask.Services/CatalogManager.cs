using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Entities;
using _3pMetricsTask.Repositories.Contracts;
using _3pMetricsTask.Services.Contracts;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services
{
    public class CatalogManager : ICatalogService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CatalogManager(IRepositoryManager maanger, IMapper mapper)
        {
            _manager = maanger;
            _mapper = mapper;
        }

        public async Task<CatalogDto> CreateOneCatalogAsync(CatalogDtoForCreate catalogDtoForCreate)
        {
            if (catalogDtoForCreate == null)
            {
                throw new ArgumentNullException();
            }

            

            var catalog = _mapper.Map<Catalog>(catalogDtoForCreate);
            _manager.Catalog.CreateOneCatalog(catalog);
            await _manager.SaveAsync();

            return _mapper.Map<CatalogDto>(catalog);
        }

        public async Task DeleteOneCatalogAsync(int id, bool trackChanges)
        {
            var catalog = await _manager.Catalog.GetOneCatalogByIdAsync(id, trackChanges);
            if (catalog == null)
            {
                throw new Exception($"Catalog with id: {id} is not found");
            }

            _manager.Catalog.DeleteOneCatalog(catalog);
            await _manager.SaveAsync();

        }

        public async Task<List<CatalogDto>> GetAllCatalogsAsync(bool trackChanges)
        {
            var catalogs = await _manager.Catalog.GetAllCatalogsAsync(trackChanges);

            if (catalogs == null)
            {
                throw new Exception("Catalog not be found");
            }

            var mappedCatalogs = _mapper.Map<List<CatalogDto>>(catalogs);
            return mappedCatalogs;
        }

        public async Task<CatalogDto> GetOneCatalogAsync(int id, bool trackChanges)
        {
            var catalog = await _manager.Catalog.GetOneCatalogByIdAsync(id, trackChanges);

            if (catalog == null)
            {
                throw new Exception($"Catalog with id: {id} is not found");
            }
            var mappedCatalog = _mapper.Map<CatalogDto>(catalog);
            return mappedCatalog;
        }

        public async Task UpdateOneCatalogAsync(int id, CatalogDtoForUpdate catalogDtoForUpdate, bool trackChanges)
        {
            var catalog = await _manager.Catalog.GetOneCatalogByIdAsync(id, trackChanges);

            if (catalog == null)
            {
                throw new Exception($"Catalog with id: {id} is not found");
            }

            if (catalogDtoForUpdate == null)
            {
                throw new Exception("Catalog Dto is null");
            }

            catalog = _mapper.Map<Catalog>(catalogDtoForUpdate);
            _manager.Catalog.UpdateOneCatalog(catalog);

            await _manager.SaveAsync();
        }
    }
}
