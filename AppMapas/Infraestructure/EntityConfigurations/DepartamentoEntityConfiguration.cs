using AppMapas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMapas.Infraestructure.EntityConfigurations
{
    public class DepartamentoEntityConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> departamentoConfiguration)
        {
            departamentoConfiguration.HasKey(d => d.Id);
            departamentoConfiguration.Property(d => d.Nombre)
                .HasMaxLength(40)
                .IsRequired()
                ;
        }
    }
}
