using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Dtos.EmissionSourcesDtos
{
    public record EmissionSourceDto
    {
        public int Id { get; init; }
        public int CreatorId { get; init; }
        public String? SourceName { get; init; }
        public String? SourceIcon { get; init; }
        public DateTime CreationDate { get; init; }
    }
}
