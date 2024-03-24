using _3pMetricsTask.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Entities
{
    public class EmissionMapping : IEntity
    {
        public int Id { get; set; }
        public int EmissionSourceId { get; set; }
        public int EmissionPointId { get; set; }
        public int SourcesUnitId { get; set; }
        public int EmissionFactorId { get; set; }

        public EmissionMapping()
        {

        }
    }
}
