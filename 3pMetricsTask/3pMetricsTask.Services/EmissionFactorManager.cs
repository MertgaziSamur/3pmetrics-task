using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionFactorDtos;
using _3pMetricsTask.Entities.Entities;
using _3pMetricsTask.Repositories.Contracts;
using _3pMetricsTask.Services.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services
{
    public class EmissionFactorManager : IEmissionFactorService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public EmissionFactorManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<EmissionFactorDto> CreateOneEmissionFactorAsync(EmissionFactorDtoForCreate emissionFactorDtoForCreate)
        {
            if (emissionFactorDtoForCreate == null)
            {
                throw new ArgumentNullException();
            }

            var emissionFactor = _mapper.Map<EmissionFactor>(emissionFactorDtoForCreate);
            _manager.EmissionFactor.CreateOneEmissionFactor(emissionFactor);
            await _manager.SaveAsync();

            return _mapper.Map<EmissionFactorDto>(emissionFactor);
        }

        public async Task DeleteOneEmissionFactorAsync(int id, bool trackChanges)
        {
            var emissionFactor = await _manager.EmissionFactor.GetOneEmissionFactorByIdAsync(id, trackChanges);

            if (emissionFactor == null)
            {
                throw new Exception($"EmissionFactor with id: {id} is not found");
            }

            _manager.EmissionFactor.DeleteOneEmissionFactor(emissionFactor);
            await _manager.SaveAsync();
        }

        public async Task<List<EmissionFactorDto>> GetAllEmissionFactorsAsync(bool trackChanges)
        {
            var emissionFactors = await _manager.EmissionFactor.GetAllEmissionFactorsAsync(trackChanges);

            if (emissionFactors == null)
            {
                throw new Exception("Emission factor not be found");
            }

            foreach (var emissionFactor in emissionFactors)
            {
                emissionFactor.Catalog = await _manager.Catalog.GetOneCatalogByIdAsync(emissionFactor.CatalogId, trackChanges);
            }

            var mappedEmissionFacor = _mapper.Map<List<EmissionFactorDto>>(emissionFactors);
            return mappedEmissionFacor;
        }

        public async Task<EmissionFactorDto> GetOneEmissionFactorAsync(int id, bool trackChanges)
        {
            var emissionFactor = await _manager.EmissionFactor.GetOneEmissionFactorByIdAsync(id, trackChanges);

            if (emissionFactor == null)
            {
                throw new Exception($"Emission Factor with id: {id} is not found");
            }

            emissionFactor.Catalog = await _manager.Catalog.GetOneCatalogByIdAsync(id, trackChanges);

            var mappedEmissionFactor = _mapper.Map<EmissionFactorDto>(emissionFactor);
            return mappedEmissionFactor;
        }

        public async Task UpdateOneEmissionFactorAsync(int id, EmissionFactorDtoForUpdate emissionFactorDtoForUpdate, bool trackChanges)
        {
            var emissionFactor = await _manager.EmissionFactor.GetOneEmissionFactorByIdAsync(id, trackChanges);

            if (emissionFactor == null)
            {
                throw new Exception($"Emission Factor with id: {id} is not found");
            }

            if (emissionFactorDtoForUpdate == null)
            {
                throw new Exception("EmissionFactorDto is null");
            }

            var mappedEmissionFactor = _mapper.Map<EmissionFactor>(emissionFactorDtoForUpdate);
            _manager.EmissionFactor.UpdateOneEmissionFactor(mappedEmissionFactor);

            await _manager.SaveAsync();

        }
    }
}
