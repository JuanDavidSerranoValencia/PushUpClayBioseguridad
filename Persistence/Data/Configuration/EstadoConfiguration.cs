using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(e => e.IdEstado).HasName("PRIMARY");

            builder.ToTable("estado");

            builder.Property(e => e.IdEstado)
                .ValueGeneratedNever()
                .HasColumnName("Id_Estado");
            builder.Property(e => e.Descripcion).HasMaxLength(45);
        }
    }
}
