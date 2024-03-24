using _3pMetricsTask.Entities.Dtos.EmissionPointDtos;
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
    public class EmissionPointManager : IEmissionPointService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public EmissionPointManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<EmissionPointDto> CreateOneEmissionPointAsync(EmissionPointDtoForCreate emissionPointDtoForCreate)
        {
            if (emissionPointDtoForCreate == null)
            {
                throw new ArgumentNullException();
            }

            var emissionPoint = _mapper.Map<EmissionPoint>(emissionPointDtoForCreate);
            _manager.EmissionPoint.CreateOneEmissionPoint(emissionPoint);
            await _manager.SaveAsync();

            return _mapper.Map<EmissionPointDto>(emissionPoint);
        }

        public async Task DeleteOneEmissionPointAsync(int id, bool trackChanges)
        {
            var emissionPoint = await _manager.EmissionPoint.GetOneEmissionPointByIdAsync(id, trackChanges);

            if (emissionPoint == null)
            {
                throw new Exception($"Emission Point with id: {id} is not found");
            }

            _manager.EmissionPoint.DeleteOneEmissionPoint(emissionPoint);
            await _manager.SaveAsync();

        }

        public async Task<List<EmissionPointDto>> GetAllEmissionPointsAsync(bool trackChanges)
        {
            var emissionPoints = await _manager.EmissionPoint.GetAllEmissionPointsAsync(trackChanges);

            if (emissionPoints == null)
            {
                throw new Exception("Emission Points not be found");
            }

            foreach (var emissionPoint in emissionPoints)
            {
                emissionPoint.EmissionSourcesUnit = await _manager.EmissionSourcesUnit.GetOneEmissionSourcesUnitByIdAsync(emissionPoint.EmissionSourcesUnitId, trackChanges);
            }

            var mappedEmissionPoints = _mapper.Map<List<EmissionPointDto>>(emissionPoints);

            return mappedEmissionPoints;
        }

        public async Task<EmissionPointDto> GetOneEmissionPointAsync(int id, bool trackChanges)
        {
            var emissionPoint = await _manager.EmissionPoint.GetOneEmissionPointByIdAsync(id, trackChanges);

            if (emissionPoint == null)
            {
                throw new Exception($"Emission Point with id: {id} is not found");
            }

            emissionPoint.EmissionSourcesUnit = await _manager.EmissionSourcesUnit.GetOneEmissionSourcesUnitByIdAsync(emissionPoint.EmissionSourcesUnitId, trackChanges);

            var mappedEmissionPoint = _mapper.Map<EmissionPointDto>(emissionPoint);

            return mappedEmissionPoint;
        }

        public async Task UpdateOneEmissionPointAsync(int id, EmissionPointDtoForUpdate emissionPointDtoForUpdate, bool trackChanges)
        {
            var emissionPoint = await _manager.EmissionPoint.GetOneEmissionPointByIdAsync(id, trackChanges);

            if (emissionPoint == null)
            {
                throw new Exception($"EmissionPoint with id: {id} is not found");
            }

            if (emissionPointDtoForUpdate == null)
            {
                throw new Exception("EmissionPoint Dto is null");
            }

            var mappedEmissionPoint = _mapper.Map<EmissionPoint>(emissionPointDtoForUpdate);
            _manager.EmissionPoint.UpdateOneEmissionPoint(mappedEmissionPoint);

            await _manager.SaveAsync();
        }
    }
}
