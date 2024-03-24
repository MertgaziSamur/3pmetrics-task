using _3pMetricsTask.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.EfCore.Config
{
    public class EmissionMappingConfig : IEntityTypeConfiguration<EmissionMapping>
    {
        public void Configure(EntityTypeBuilder<EmissionMapping> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new EmissionMapping { Id = 1, EmissionSourceId = 1, EmissionPointId = 1, SourcesUnitId = 4, EmissionFactorId = 1 },
                new EmissionMapping { Id = 2, EmissionSourceId = 1, EmissionPointId = 3, SourcesUnitId = 1, EmissionFactorId = 1 },
                new EmissionMapping { Id = 3, EmissionSourceId = 2, EmissionPointId = 2, SourcesUnitId = 2, EmissionFactorId = 2 },
                new EmissionMapping { Id = 4, EmissionSourceId = 2, EmissionPointId = 4, SourcesUnitId = 3, EmissionFactorId = 3 }
                );
        }
    }
}
