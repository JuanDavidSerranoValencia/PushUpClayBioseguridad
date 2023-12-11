using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TurnoConfiguration : IEntityTypeConfiguration<Turno>
    {
        public void Configure(EntityTypeBuilder<Turno> builder)
        {
            builder.HasKey(e => e.IdTurnos).HasName("PRIMARY");

            builder.ToTable("turnos");

            builder.Property(e => e.IdTurnos)
                .ValueGeneratedNever()
                .HasColumnName("Id_Turnos");
            builder.Property(e => e.HoraTurnoFin)
                .HasMaxLength(45)
                .HasColumnName("horaTurnoFin");
            builder.Property(e => e.HoraTurnoIng)
                .HasMaxLength(45)
                .HasColumnName("horaTurnoIng");
            builder.Property(e => e.NombreTurnos)
                .HasMaxLength(45)
                .HasColumnName("nombreTurnos");
        }
    }
}
