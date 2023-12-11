using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
    {
        public void Configure(EntityTypeBuilder<Programacion> builder)
        {
              builder.HasKey(e => e.IdProgramacion).HasName("PRIMARY");

            builder.ToTable("programacion");

            builder.HasIndex(e => e.IdContratoFk, "fk_Programacion_Contrato1_idx");

            builder.HasIndex(e => e.IdPersonaFk, "fk_Programacion_Persona1_idx");

            builder.HasIndex(e => e.IdTurnoFk, "fk_Programacion_Turnos1_idx");

            builder.Property(e => e.IdProgramacion)
                .ValueGeneratedNever()
                .HasColumnName("Id_Programacion");
            builder.Property(e => e.IdContratoFk).HasColumnName("Id_ContratoFk");
            builder.Property(e => e.IdPersonaFk).HasColumnName("Id_PersonaFk");
            builder.Property(e => e.IdTurnoFk).HasColumnName("Id_TurnoFk");

            builder.HasOne(d => d.IdContratoFkNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdContratoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Programacion_Contrato1");

            builder.HasOne(d => d.IdPersonaFkNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Programacion_Persona1");

            builder.HasOne(d => d.IdTurnoFkNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdTurnoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Programacion_Turnos1");
        }
    }
}
