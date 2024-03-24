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
    public class CatalogConfig : IEntityTypeConfiguration<Catalog>
    {
        public void Configure(EntityTypeBuilder<Catalog> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(
                    new Catalog { Id = 1, CatalogIdHash = "5c46ab9ac03397da3f2aa22445b460bf54d968a1cf8084e3e252ff2d209e8bf4", CreatorId = 1, CatalogName = "3P EFDB", CreationDate = DateTime.Now },
                    new Catalog { Id = 2, CatalogIdHash = "38d5680b88846d2f2640fb561bfb07318039b80b480e298117334522e4c1a454", CreatorId = 1, CatalogName = "Defra", CreationDate = DateTime.Now }
                );
        }
    }
}
