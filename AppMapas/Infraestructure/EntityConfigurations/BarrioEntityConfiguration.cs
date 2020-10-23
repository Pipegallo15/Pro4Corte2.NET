using AppMapas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppMapas.Infraestructure.EntityConfigurations
{
    public class BarrioEntityConfiguration: IEntityTypeConfiguration<Barrio>
    {
        public void Configure(EntityTypeBuilder<Barrio> barrioConfiguration)
        {
            barrioConfiguration.HasKey(b => b.Id);
            barrioConfiguration.Property(b => b.Nombre)
                .HasMaxLength(40)
                .IsRequired()
                ;
            barrioConfiguration.Property<Guid>("_idMunicipio")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("municipioId")
                .IsRequired(true);
            barrioConfiguration.HasOne(b => b.Municipio)
                .WithMany()
                .HasForeignKey("_idMunicipio");
        }
    }
}
