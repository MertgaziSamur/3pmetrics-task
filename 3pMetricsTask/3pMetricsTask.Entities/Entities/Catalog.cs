using _3pMetricsTask.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Entities
{
    public class Catalog : IEntity
    {
        public int Id { get; set; }
        public String? CatalogIdHash { get; set; }
        public int CreatorId { get; set; }
        public String? CatalogName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<EmissionFactor>? EmissionFactors { get; set; }
        public Catalog()
        {
            CreationDate = DateTime.Now;
        }
    }
}
