using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;

    public interface IUnitOfWork
{
        ICategoriaPersona CategoriaPersonas { get; }
        ICiudad Ciudads { get; }
        IContactoPersona ContactoPersonas { get; }
        IContrato Contratos { get; }
        IDepartamento Departamentos { get; }
        IDireccionPersona DireccionPersonas { get; }
        IEstado Estados { get; }
        IPais Paiss { get; }
        IPersona Personas { get; }
        IProgramacion Programacions { get; }
       /*  IRefreshToken RefreshTokens { get; } */
        ITipoContacto TipoContactos { get; }
        ITipoDireccion TipoDireccions { get; }
        ITipoPersona TipoPersonas { get; }
        ITurno Turnos { get; }
        Task<int> SaveAsync();
}
