using _3pMetricsTask.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Entities
{
    public class EmissionPoint : IEntity
    {
        public int Id { get; set; }
        public String? PointIdHash { get; set; }
        public int EmissionSourcesUnitId { get; set; }
        public EmissionSourcesUnit? EmissionSourcesUnit { get; set; }
        public int CreatorId { get; set; }
        public String? PointName { get; set; }
        public String? PointDescription { get; set; }
        public String? PointIcon { get; set; }
        public DateTime CreationDate { get; set; }
        public EmissionPoint()
        {
            CreationDate = DateTime.Now;
        }
    }
}
