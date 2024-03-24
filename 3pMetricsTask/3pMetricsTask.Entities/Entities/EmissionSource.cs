using _3pMetricsTask.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Entities.Entities
{
    public class EmissionSource : IEntity
    {
        public int Id { get; set; }
        public String? SourceIdHash { get; set; }
        public int CreatorId { get; set; }
        public String? SourceName { get; set; }
        public String? SourceIcon { get; set; }
        public DateTime CreationDate { get; set; }

        public EmissionSource()
        {
            CreationDate = DateTime.Now;
        }
    }
}
