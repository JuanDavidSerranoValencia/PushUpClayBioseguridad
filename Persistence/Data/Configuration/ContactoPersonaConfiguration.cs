using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
    {
        public void Configure(EntityTypeBuilder<ContactoPersona> builder)
        {
            builder.HasKey(e => e.IdContactoPersona).HasName("PRIMARY");

            builder.ToTable("contactopersona");

            builder.HasIndex(e => e.IdPersonaFk, "fk_ContactoPersona_Persona1_idx");

            builder.HasIndex(e => e.IdTipoContactoFk, "fk_ContactoPersona_TipoContacto1_idx");

            builder.Property(e => e.IdContactoPersona)
                .ValueGeneratedNever()
                .HasColumnName("Id_ContactoPersona");
            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(45);
            builder.Property(e => e.IdPersonaFk).HasColumnName("Id_PersonaFk");
            builder.Property(e => e.IdTipoContactoFk).HasColumnName("Id_TipoContactoFk");

            builder.HasOne(d => d.IdPersonaFkNavigation).WithMany(p => p.Contactopersonas)
                .HasForeignKey(d => d.IdPersonaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ContactoPersona_Persona1");

            builder.HasOne(d => d.IdTipoContactoFkNavigation).WithMany(p => p.Contactopersonas)
                .HasForeignKey(d => d.IdTipoContactoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ContactoPersona_TipoContacto1");
        }
    }
}
