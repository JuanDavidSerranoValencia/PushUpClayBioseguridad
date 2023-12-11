using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
             builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contrato");

            builder.HasIndex(e => e.IdEstadoFk, "fk_Contrato_Estado1_idx");

            builder.HasIndex(e => e.IdPersonaFk, "fk_Contrato_Persona1_idx");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.IdEstadoFk).HasColumnName("Id_EstadoFk");
            builder.Property(e => e.IdPersonaFk).HasColumnName("Id_PersonaFk");

            builder.HasOne(d => d.IdEstadoFkNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdEstadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Contrato_Estado1");

            builder.HasOne(d => d.IdPersonaFkNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Contrato_Persona1");
        }
    }
}
