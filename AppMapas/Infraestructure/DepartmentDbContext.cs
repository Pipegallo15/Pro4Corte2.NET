using AppMapas.Domain;
using AppMapas.Infraestructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMapas.Infraestructure
{
    public class DepartmentDbContext:DbContext
    {
        public DepartmentDbContext (DbContextOptions<DepartmentDbContext> options) : base(options) { }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Barrio> Barrio { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DepartamentoEntityConfiguration());
            builder.ApplyConfiguration(new MunicipioEntityConfiguration());
            builder.ApplyConfiguration(new BarrioEntityConfiguration());

        }
    }
}
