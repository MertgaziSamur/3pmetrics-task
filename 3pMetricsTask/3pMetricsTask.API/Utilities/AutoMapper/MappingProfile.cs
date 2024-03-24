using _3pMetricsTask.Entities.Dtos.CatalogDtos;
using _3pMetricsTask.Entities.Dtos.EmissionFactorDtos;
using _3pMetricsTask.Entities.Dtos.EmissionPointDtos;
using _3pMetricsTask.Entities.Dtos.EmissionSourcesDtos;
using _3pMetricsTask.Entities.Dtos.EmissionSourcesUnitDtos;
using _3pMetricsTask.Entities.Entities;
using AutoMapper;

namespace _3pMetricsTask.API.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Catalog, CatalogDtoForCreate>().ReverseMap();
            CreateMap<Catalog, CatalogDtoForUpdate>().ReverseMap();
            CreateMap<Catalog, CatalogDto>().ReverseMap();

            CreateMap<EmissionFactor, EmissionFactorDto>().ReverseMap();
            CreateMap<EmissionFactor, EmissionFactorDtoForCreate>().ReverseMap();
            CreateMap<EmissionFactor, EmissionFactorDtoForUpdate>().ReverseMap();

            CreateMap<EmissionPoint, EmissionPointDto>().ReverseMap();
            CreateMap<EmissionPoint, EmissionPointDtoForCreate>().ReverseMap();
            CreateMap<EmissionPoint, EmissionPointDtoForUpdate>().ReverseMap();

            CreateMap<EmissionSource, EmissionSourceDto>().ReverseMap();
            CreateMap<EmissionSource, EmissionSourceDtoForCreate>().ReverseMap();
            CreateMap<EmissionSource, EmissionSourceDtoForUpdate>().ReverseMap();

            CreateMap<EmissionSourcesUnit, EmissionSourcesUnitDto>().ReverseMap();
            CreateMap<EmissionSourcesUnit, EmissionSourcesUnitDtoForCreate>().ReverseMap();
            CreateMap<EmissionSourcesUnit, EmissionSourcesUnitDtoForUpdate>().ReverseMap();
        }
    }
}
