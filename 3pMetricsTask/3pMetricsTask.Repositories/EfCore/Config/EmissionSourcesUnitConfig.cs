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
    public class EmissionSourcesUnitConfig : IEntityTypeConfiguration<EmissionSourcesUnit>
    {
        public void Configure(EntityTypeBuilder<EmissionSourcesUnit> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                new EmissionSourcesUnit { Id = 1, UnitIdHash = "e6a874d555fefd3686b70114687a7f03ae4dc2c46d56509f59a223ef6c225f9a", CreatorId = 1, UnitTitle = "Litre", UnitSymbol = Entities.Enums.Symbols.LT, CreationDate = DateTime.Now.AddDays(2) },
                new EmissionSourcesUnit { Id = 2, UnitIdHash = "adba1db0a09fda86bf0ac887088a33f4042bd29c80132e7443c33e3098cf02de", CreatorId = 1, UnitTitle = "Ton", UnitSymbol = Entities.Enums.Symbols.TON, CreationDate = DateTime.Now },
                new EmissionSourcesUnit { Id = 3, UnitIdHash = "da8ea261cc933a43d3650d9cbfdf9af41c4c6fabf08e480ae0f7371fb70051b8", CreatorId = 1, UnitTitle = "Litre", UnitSymbol = Entities.Enums.Symbols.LT, CreationDate = DateTime.Now.AddDays(3) },
                new EmissionSourcesUnit { Id = 4, UnitIdHash = "58e822cfb67cb3edfd7ac6674867e6a0cf1210e6834051d34eddbfdac16271f4", CreatorId = 1, UnitTitle = "m3", UnitSymbol = Entities.Enums.Symbols.M3, CreationDate = DateTime.Now.AddDays(1) },
                new EmissionSourcesUnit { Id = 5, UnitIdHash = "d672643d8cae9ff7933f7fffac4b22048162022a04adaf1b6ae120eae2dac6ae", CreatorId = 1, UnitTitle = "kwh", UnitSymbol = Entities.Enums.Symbols.KWH, CreationDate = DateTime.Now.AddDays(1) }
                );
        }
    }
}
