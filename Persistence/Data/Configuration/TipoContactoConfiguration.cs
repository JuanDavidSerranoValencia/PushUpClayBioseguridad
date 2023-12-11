using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoContactoConfiguration : IEntityTypeConfiguration<TipoContacto>
    {
        public void Configure(EntityTypeBuilder<TipoContacto> builder)
        {
            builder.HasKey(e => e.IdTipoContacto).HasName("PRIMARY");

            builder.ToTable("tipocontacto");

            builder.Property(e => e.IdTipoContacto)
                .ValueGeneratedNever()
                .HasColumnName("Id_TipoContacto");
            builder.Property(e => e.Descripcion).HasMaxLength(100);
        }
    }
}
