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
    public class EmissionFactorConfig : IEntityTypeConfiguration<EmissionFactor>
    {
        public void Configure(EntityTypeBuilder<EmissionFactor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                    new EmissionFactor { Id = 1, EmissionIdHash = "2f6e474a6b719109f4a92d67caa6d9d5b0e3b0fbdcdf70d0f621a693bf6dafff", CatalogId = 1, CreatorId = 1,  EmissionFactorTitle = "Doğalgaz NRM", EmissionFactorValue = 2.00054, EffectiveStartDate = DateTime.Now, EffectiveEndDate = DateTime.Now.AddDays(3), CreationDate = DateTime.Now },
                    new EmissionFactor { Id = 2, EmissionIdHash = "90835cced12fe2db8e2b28217c36224ce6426317b3795db708c0ee7e2a886d32", CatalogId = 1, CreatorId = 1, EmissionFactorTitle = "Diesel Ton", EmissionFactorValue = 1.8E-05, EffectiveStartDate = DateTime.Now, EffectiveEndDate = DateTime.Now.AddDays(5), CreationDate = DateTime.Now },
                    new EmissionFactor { Id = 3, EmissionIdHash = "90835cced12fe2db8e2b28217c36224ce6426317b3795db708c0ee7e2a886d32", CatalogId = 1, CreatorId = 1, EmissionFactorTitle = "Doğalgaz Tren", EmissionFactorValue = 2.8E-05, EffectiveStartDate = DateTime.Now, EffectiveEndDate = DateTime.Now.AddDays(8), CreationDate = DateTime.Now }
                );
        }
    }
}
