using _3pMetricsTask.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Repositories.EfCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<EmissionFactor> EmissionFactors { get; set; }
        public DbSet<EmissionMapping> EmissionMappings { get; set; }
        public DbSet<EmissionPoint> EmissionPoints { get; set; }
        public DbSet<EmissionSource> EmissionSources { get; set; }
        public DbSet<EmissionSourcesUnit> EmissionSourcesUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
