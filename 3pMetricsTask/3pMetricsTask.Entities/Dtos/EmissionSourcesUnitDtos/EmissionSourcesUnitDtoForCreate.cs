using _3pMetricsTask.Entities.Entities;
using _3pMetricsTask.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Dtos.EmissionSourcesUnitDtos
{
    public record EmissionSourcesUnitDtoForCreate
    {
        public int CreatorId { get; init; }
        public String? UnitTitle { get; init; }
        public Symbols UnitSymbol { get; init; }
        public DateTime CreationDate { get; init; }
    }
}
