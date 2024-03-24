using _3pMetricsTask.Entities.Dtos.EmissionSourcesDtos;
using _3pMetricsTask.Entities.Dtos.EmissionSourcesUnitDtos;
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
    public class EmissionSourcesUnitManager : IEmissionSourcesUnitService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public EmissionSourcesUnitManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public async Task<EmissionSourcesUnitDto> CreateOneEmissionSourcesUnitAsync(EmissionSourcesUnitDtoForCreate emissionSourcesUnitDtoForCreate)
        {
            if (emissionSourcesUnitDtoForCreate == null)
            {
                throw new ArgumentNullException();
            }

            var emissionSourcesUnit = _mapper.Map<EmissionSourcesUnit>(emissionSourcesUnitDtoForCreate);
            _manager.EmissionSourcesUnit.CreateOneEmissionSourcesUnit(emissionSourcesUnit);
            await _manager.SaveAsync();

            return _mapper.Map<EmissionSourcesUnitDto>(emissionSourcesUnit);
        }

        public async Task DeleteOneEmissionSourcesUnitAsync(int id, bool trackChanges)
        {
            var emissionSourcesUnit = await _manager.EmissionSourcesUnit.GetOneEmissionSourcesUnitByIdAsync(id, trackChanges);

            if (emissionSourcesUnit == null)
            {
                throw new Exception($"Emission Source Unit with id: {id} is not found");
            }

            _manager.EmissionSourcesUnit.DeleteOneEmissionSourcesUnit(emissionSourcesUnit);
            await _manager.SaveAsync();
        }

        public async Task<List<EmissionSourcesUnitDto>> GetAllEmissionSourcesUnitAsync(bool trackChanges)
        {
            var emissionSourcesUnits = await _manager.EmissionSourcesUnit.GetAllEmissionSourcesUnitsAsync(trackChanges);

            foreach (var emissionSourcesUnit in emissionSourcesUnits)
            {
                emissionSourcesUnit.UnitSymbol.ToString();
            }

            if (emissionSourcesUnits == null)
            {
                throw new Exception("Emission Sources Units not be found");
            }

            var mappedEmissionSourcesUnits = _mapper.Map<List<EmissionSourcesUnitDto>>(emissionSourcesUnits);

            return mappedEmissionSourcesUnits;
        }

        public async Task<EmissionSourcesUnitDto> GetOneEmissionSourcesUnitAsync(int id, bool trackChanges)
        {
            var emissionSourcesUnit = await _manager.EmissionSourcesUnit.GetOneEmissionSourcesUnitByIdAsync(id, trackChanges);

            if (emissionSourcesUnit == null)
            {
                throw new Exception($"Emission Sources Unit with id: {id} is not found");
            }

            emissionSourcesUnit.UnitSymbol.ToString();

            var mappedEmissionSourcesUnit = _mapper.Map<EmissionSourcesUnitDto>(emissionSourcesUnit);

            return mappedEmissionSourcesUnit;
        }

        public async Task UpdateOneEmissionSourcesUnitAsync(int id, EmissionSourcesUnitDtoForUpdate emissionSourcesUnitDtoForUpdate, bool trackChanges)
        {
            var emissionSourceUnit = await _manager.EmissionSourcesUnit.GetOneEmissionSourcesUnitByIdAsync(id, trackChanges);

            if (emissionSourceUnit == null)
            {
                throw new Exception($"EmissionSourceUnit with id: {id} is not found");
            }

            if (emissionSourcesUnitDtoForUpdate == null)
            {
                throw new Exception("EmissionSourcesUnit Dto is null");
            }

            var mappedEmissionSourcesUnit = _mapper.Map<EmissionSourcesUnit>(emissionSourcesUnitDtoForUpdate);
            _manager.EmissionSourcesUnit.UpdateOneEmissionSourcesUnit(mappedEmissionSourcesUnit);

            await _manager.SaveAsync();
        }
    }
}
