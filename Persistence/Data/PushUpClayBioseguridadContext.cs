using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class PushUpClayBioseguridadContext : DbContext
    {
        public PushUpClayBioseguridadContext(DbContextOptions<PushUpClayBioseguridadContext> options) : base(options)
        {
        }

        public DbSet<CategoriaPersona> CategoriaPersonas { get; set; }
        public DbSet<Ciudad> Ciudads { get; set; }
        public DbSet<ContactoPersona> ContactoPersonas { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<DireccionPersona> DireccionPersonas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Pais> Paiss { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Programacion> Programacions { get; set; }
        public DbSet<TipoContacto> TipoContactos { get; set; }
        public DbSet<TipoDireccion> TipoDireccions { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
