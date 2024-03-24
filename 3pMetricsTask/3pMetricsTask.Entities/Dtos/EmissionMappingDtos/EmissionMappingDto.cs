using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Dtos.EmissionMappingDtos
{
    public record EmissionMappingDto
    {
        public int Id { get; init; }
        public int EmissionSourceId { get; init; }
        public int EmissionPointId { get; init; }
        public int SourcesUnitId { get; init; }
        public int EmissionFactorId { get; init; }
    }
}
