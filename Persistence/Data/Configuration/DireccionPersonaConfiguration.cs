using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DireccionPersonaConfiguration : IEntityTypeConfiguration<DireccionPersona>
    {
        public void Configure(EntityTypeBuilder<DireccionPersona> builder)
        {
            builder.HasKey(e => e.IdDirPersona).HasName("PRIMARY");

            builder.ToTable("direccionpersona");

            builder.HasIndex(e => e.IdPersonaFk, "fk_DirPersona_Persona1_idx");

            builder.HasIndex(e => e.IdTipoDireccionFk, "fk_DireccionPersona_TipoDireccion1_idx");

            builder.Property(e => e.IdDirPersona)
                .ValueGeneratedNever()
                .HasColumnName("Id_DirPersona");
            builder.Property(e => e.Direccion).HasMaxLength(45);
            builder.Property(e => e.IdPersonaFk).HasColumnName("Id_PersonaFk");
            builder.Property(e => e.IdTipoDireccionFk).HasColumnName("Id_TipoDireccionFk");

            builder.HasOne(d => d.IdPersonaFkNavigation).WithMany(p => p.Direccionpersonas)
                .HasForeignKey(d => d.IdPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DirPersona_Persona1");

            builder.HasOne(d => d.IdTipoDireccionFkNavigation).WithMany(p => p.Direccionpersonas)
                .HasForeignKey(d => d.IdTipoDireccionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_DireccionPersona_TipoDireccion1");
        }
    }
}
