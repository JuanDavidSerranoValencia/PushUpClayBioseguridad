using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
             builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("persona");

            builder.HasIndex(e => e.IdCategoriaPersonaFk, "fk_Persona_CategoriaPersona1_idx");

            builder.HasIndex(e => e.IdCiudadFk, "fk_Persona_Ciudad1_idx");

            builder.HasIndex(e => e.IdTipoPersonaFk, "fk_Persona_TipoPersona1_idx");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.IdCategoriaPersonaFk).HasColumnName("Id_CategoriaPersonaFk");
            builder.Property(e => e.IdCiudadFk).HasColumnName("Id_CiudadFk");
            builder.Property(e => e.IdPersona).HasColumnName("Id_Persona");
            builder.Property(e => e.IdTipoPersonaFk).HasColumnName("Id_TipoPersonaFk");
            builder.Property(e => e.Nombre).HasMaxLength(45);

            builder.HasOne(d => d.IdCategoriaPersonaFkNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdCategoriaPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Persona_CategoriaPersona1");

            builder.HasOne(d => d.IdCiudadFkNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdCiudadFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Persona_Ciudad1");

            builder.HasOne(d => d.IdTipoPersonaFkNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdTipoPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Persona_TipoPersona1");
        }
    }
}
