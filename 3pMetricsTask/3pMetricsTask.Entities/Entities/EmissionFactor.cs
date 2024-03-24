using _3pMetricsTask.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Entities
{
    public class EmissionFactor : IEntity
    {
        public int Id { get; set; }
        public String? EmissionIdHash { get; set; }
        public int CatalogId { get; set; }
        public Catalog? Catalog { get; set; }
        public int CreatorId { get; set; }
        public String? EmissionFactorTitle { get; set; }
        public double EmissionFactorValue { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public DateTime CreationDate { get; set; }

        public EmissionFactor()
        {
            CreationDate = DateTime.Now;
        }
    }
}
