using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CategoriaPersonaConfiguration : IEntityTypeConfiguration<CategoriaPersona>
    {
        public void Configure(EntityTypeBuilder<CategoriaPersona> builder)
        {
             builder.HasKey(e => e.IdCategoriaPer).HasName("PRIMARY");

            builder.ToTable("categoriapersona");

            builder.Property(e => e.IdCategoriaPer)
                .ValueGeneratedNever()
                .HasColumnName("Id_CategoriaPer");
            builder.Property(e => e.NombreCat).HasMaxLength(200);
        }
    }
}
