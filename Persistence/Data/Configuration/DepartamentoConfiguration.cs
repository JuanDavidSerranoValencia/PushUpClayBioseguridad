using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
             builder.HasKey(e => e.IdDepartamento).HasName("PRIMARY");

            builder.ToTable("departamento");

            builder.HasIndex(e => e.IdPaisFk, "fk_Departamento_Pais_idx");

            builder.Property(e => e.IdDepartamento)
                .ValueGeneratedNever()
                .HasColumnName("Id_Departamento");
            builder.Property(e => e.IdPaisFk).HasColumnName("Id_PaisFk");
            builder.Property(e => e.NombreDep).HasMaxLength(45);

            builder.HasOne(d => d.IdPaisFkNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.IdPaisFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Departamento_Pais");
        }
    }
}
