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
    public class EmissionSourceConfig : IEntityTypeConfiguration<EmissionSource>
    {
        public void Configure(EntityTypeBuilder<EmissionSource> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                    new EmissionSource { Id = 1, SourceIdHash = "81fe3ee86f53385ce50467730e7193b9ceac0d234e97356e754d5a25cc27d976", CreatorId = 1, SourceName = "Doğalgaz", SourceIcon = "naturalgas.png", CreationDate = DateTime.Now },
                    new EmissionSource { Id = 2, SourceIdHash = "6810ed4e69870ffdffab5c39f555eaa33bf1a02f4da074a220ed1d32c123599e", CreatorId = 1, SourceName = "Dizel", SourceIcon = "diesel.png", CreationDate = DateTime.Now },
                    new EmissionSource { Id = 3, SourceIdHash = "1fe5079c6104aa8e1b6f415a1c60c4239d44236f24604d413f9adc7d596f7c6d", CreatorId = 1, SourceName = "Benzin", SourceIcon = "petrol.png", CreationDate = DateTime.Now }
                );
        }
    }
}
