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
    public class EmissionPointConfig : IEntityTypeConfiguration<EmissionPoint>
    {
        public void Configure(EntityTypeBuilder<EmissionPoint> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(
                    new EmissionPoint { Id = 1, PointIdHash = "c22cf6c32975aa7e8fd5b9c77de2e9083233743023abaa6f42a6ce65e712a29c", PointName = "Kombi", PointDescription = "Kombilerde tüketilen enerji", PointIcon = "kombi.png", CreationDate = DateTime.Now.AddDays(1), CreatorId = 1, EmissionSourcesUnitId = 1 },
                    new EmissionPoint { Id = 2, PointIdHash = "57a58df97aa1b8a380429c3402ceb34ccab2d7275380feb63f65a3af4c94e78e", PointName = "Binek Araç", PointDescription = "Binek araçlarda tüketilen yakıtlar", PointIcon = "car.png", CreationDate = DateTime.Now.AddDays(3), CreatorId = 1, EmissionSourcesUnitId = 2 },
                    new EmissionPoint { Id = 3, PointIdHash = "25fafd96f2830e1b3a3c88a8f4234e120ee9b41b3b5824f175586a50894458fa", PointName = "Fabrika", PointDescription = "Fabrikalarda kullanılan enerji", PointIcon = "industry.png", CreationDate = DateTime.Now.AddDays(2), CreatorId = 1, EmissionSourcesUnitId = 1 },
                    new EmissionPoint { Id = 4, PointIdHash = "f3acbbdf3f3df94df27bc57f350016b7dd52ebd6dcd6b218caf9645302cbaeb0", PointName = "Kamyon", PointDescription = "Kamyonlarda tüketilen yakıt", PointIcon = "truck.png", CreationDate = DateTime.Now.AddDays(2), CreatorId = 1, EmissionSourcesUnitId = 2 }
                );
        }
    }
}
