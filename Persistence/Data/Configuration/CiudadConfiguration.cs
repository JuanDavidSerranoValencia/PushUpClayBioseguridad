using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.HasKey(e => e.IdCiudad).HasName("PRIMARY");

            builder.ToTable("ciudad");

            builder.HasIndex(e => e.IdDepartamentoFk, "fk_Ciudad_Departamento1_idx");

            builder.Property(e => e.IdCiudad)
                .ValueGeneratedNever()
                .HasColumnName("Id_Ciudad");
            builder.Property(e => e.IdDepartamentoFk).HasColumnName("Id_DepartamentoFk");
            builder.Property(e => e.NombreCiudad).HasMaxLength(45);

            builder.HasOne(d => d.IdDepartamentoFkNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.IdDepartamentoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Ciudad_Departamento1");
        }
    }
}
