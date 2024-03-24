using _3pMetricsTask.Entities.Contracts;
using _3pMetricsTask.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Entities
{
    public class EmissionSourcesUnit : IEntity
    {
        public int Id { get; set; }
        public String? UnitIdHash { get; set; }
        public int CreatorId { get; set; }
        public String? UnitTitle { get; set; }
        public Symbols UnitSymbol { get; set; }
        public DateTime CreationDate { get; set; }
        public List<EmissionPoint>? EmissionPoints { get; set; }

        public EmissionSourcesUnit()
        {
            CreationDate = DateTime.Now;
        }
    }
}
