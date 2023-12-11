using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoDireccionConfiguration : IEntityTypeConfiguration<TipoDireccion>
    {
        public void Configure(EntityTypeBuilder<TipoDireccion> builder)
        {
             builder.HasKey(e => e.IdTipoDireccion).HasName("PRIMARY");

            builder.ToTable("tipodireccion");

            builder.Property(e => e.IdTipoDireccion)
                .ValueGeneratedNever()
                .HasColumnName("Id_TipoDireccion");
            builder.Property(e => e.Descripcion).HasMaxLength(45);
        }
    }
}
