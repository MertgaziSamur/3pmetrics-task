using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Dtos.EmissionFactorDtos
{
    public record EmissionFactorDtoForUpdate
    {
        public int Id { get; init; }
        public int CatalogId { get; init; }
        public int CreatorId { get; init; }
        public String? EmissionFactorTitle { get; init; }
        public double EmissionFactorValue { get; init; }
        public DateTime EffectiveStartDate { get; init; }
        public DateTime EffectiveEndDate { get; init; }
        public DateTime CreationDate { get; init; }
    }
}
