using AppMapas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMapas.Infraestructure.EntityConfigurations
{
    public class MunicipioEntityConfiguration: IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> municipioConfiguration)
        {
            municipioConfiguration.HasKey(m => m.Id);
            municipioConfiguration.Property(m => m.Nombre)
                .HasMaxLength(40)
                .IsRequired()
                ;
            municipioConfiguration.Property<Guid>("_idDepartamento")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("departamentoId")
                .IsRequired(true);
            municipioConfiguration.HasOne(m => m.Departamento)
               .WithMany()
               .HasForeignKey("_idDepartamento");
        }
    }
}
