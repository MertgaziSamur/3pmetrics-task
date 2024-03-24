using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Dtos.EmissionPointDtos
{
    public record EmissionPointDto
    {
        public int Id { get; init; }
        public int EmissionSourcesUnitId { get; init; }
        public EmissionSourcesUnit? EmissionSourcesUnit { get; init; }
        public int CreatorId { get; init; }
        public String? PointName { get; init; }
        public String? PointDescription { get; init; }
        public String? PointIcon { get; init; }
        public DateTime CreationDate { get; init; }
    }
}
