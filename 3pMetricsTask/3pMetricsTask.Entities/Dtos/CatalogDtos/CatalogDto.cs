using _3pMetricsTask.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Dtos.CatalogDtos
{
    public record CatalogDto
    {
        public int Id { get; init; }
        public int CreatorId { get; init; }
        public String? CatalogName { get; init; }
        public DateTime CreationDate { get; init; }
        // public List<EmissionFactor>? EmissionFactors { get; init; }
    }
}
