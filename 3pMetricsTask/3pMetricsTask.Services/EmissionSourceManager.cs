using _3pMetricsTask.Entities.Dtos.EmissionPointDtos;
using _3pMetricsTask.Entities.Dtos.EmissionSourcesDtos;
using _3pMetricsTask.Entities.Entities;
using _3pMetricsTask.Repositories.Contracts;
using _3pMetricsTask.Services.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services
{
    public class EmissionSourceManager : IEmissionSourceService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public EmissionSourceManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<EmissionSourceDto> CreateOneEmissionSourceAsync(EmissionSourceDtoForCreate emissionSourceDtoForCreate)
        {
            if (emissionSourceDtoForCreate == null)
            {
                throw new ArgumentNullException();
            }

            var emissionSource = _mapper.Map<EmissionSource>(emissionSourceDtoForCreate);
            _manager.EmissionSource.CreateOneEmissionSource(emissionSource);
            await _manager.SaveAsync();

            return _mapper.Map<EmissionSourceDto>(emissionSource);
        }

        public async Task DeleteOneEmissionSourceAsync(int id, bool trackChanges)
        {
            var emissionSource = await _manager.EmissionSource.GetOneEmissionSourceByIdAsync(id, trackChanges);

            if (emissionSource == null)
            {
                throw new Exception($"Emission Source with id: {id} is not found");
            }

            _manager.EmissionSource.DeleteOneEmissionSource(emissionSource);
            await _manager.SaveAsync();
        }

        public async Task<List<EmissionSourceDto>> GetAllEmissionSourcesAsync(bool trackChanges)
        {
            var emissionSources = await _manager.EmissionSource.GetAllEmissionSourcesAsync(trackChanges);

            if (emissionSources == null)
            {
                throw new Exception("Emission Source not be found");
            }

            var mappedEmissionSource = _mapper.Map<List<EmissionSourceDto>>(emissionSources);

            return mappedEmissionSource;
        }

        public async Task<EmissionSourceDto> GetOneEmissionSourceAsync(int id, bool trackChanges)
        {
            var emissionSource = await _manager.EmissionSource.GetOneEmissionSourceByIdAsync(id, trackChanges);

            if (emissionSource == null)
            {
                throw new Exception($"Emission Source with id: {id} is not found");
            }

            var mappedEmissionSource = _mapper.Map<EmissionSourceDto>(emissionSource);

            return mappedEmissionSource;
        }

        public async Task UpdateOneEmissionSourceAsync(int id, EmissionSourceDtoForUpdate emissionSourceDtoForUpdate, bool trackChanges)
        {
            var emissionSource = await _manager.EmissionSource.GetOneEmissionSourceByIdAsync(id, trackChanges);

            if (emissionSource == null)
            {
                throw new Exception($"EmissionSource with id: {id} is not found");
            }

            if (emissionSourceDtoForUpdate == null)
            {
                throw new Exception("EmissionSource Dto is null");
            }

            var mappedEmissionSource = _mapper.Map<EmissionSource>(emissionSourceDtoForUpdate);
            _manager.EmissionSource.UpdateOneEmissionSource(mappedEmissionSource);

            await _manager.SaveAsync();
        }
    }
}
