using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
             builder.HasKey(e => e.IdTipoPersona).HasName("PRIMARY");

            builder.ToTable("tipopersona");

            builder.Property(e => e.IdTipoPersona)
                .ValueGeneratedNever()
                .HasColumnName("Id_TipoPersona");
            builder.Property(e => e.Descripcion).HasMaxLength(100);
        }
    }
}
