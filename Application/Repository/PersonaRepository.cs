using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository
{
    public class PersonaRepository : GenericRepository<Persona>, IPersona
    {
        public PushUpClayBioseguridadContext _context { get; set; }
        public PersonaRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }




        public async Task<IEnumerable<object>> ContactosVigilantes()
        {
            var contactosVigilante = from persona in _context.Personas
                                     join tipoPersona in _context.TipoPersonas on persona.IdTipoPersonaFk equals tipoPersona.IdTipoPersona
                                     where tipoPersona.Descripcion == "Empleado" && tipoPersona.Descripcion == "Vigilante"
                                     join contacto in _context.ContactoPersonas on persona.Id equals contacto.IdPersonaFk
                                     join tipoContacto in _context.TipoContactos on contacto.IdTipoContactoFk equals tipoContacto.IdTipoContacto
                                     select new
                                     {
                                         NombreEmpleado = persona.Nombre,
                                         TipoPersona = tipoPersona.Descripcion,
                                         TipoContacto = tipoContacto.Descripcion,
                                         NumeroContacto = contacto.Descripcion
                                     };

            return contactosVigilante;
        }

        public async Task<IEnumerable<object>> ClientesBucaramanga()
        {
            var clientesBucaramanga = from persona in _context.Personas
                                      join ciudad in _context.Ciudads on persona.IdCiudadFk equals ciudad.IdCiudad
                                      join tipoPersona in _context.TipoPersonas on persona.IdTipoPersonaFk equals tipoPersona.IdTipoPersona
                                      where ciudad.NombreCiudad == "Bucaramanga" && tipoPersona.Descripcion == "Cliente"
                                      select new
                                      {
                                          NombreCliente = persona.Nombre,
                                          Ciudad = ciudad.NombreCiudad
                                      };


            return clientesBucaramanga;


        }

        public async Task<IEnumerable<object>> GironPiedecuesta()
        {

            var GironPiedecuesta = from persona in _context.Personas
                                   join ciudad in _context.Ciudads on persona.IdCiudadFk equals ciudad.IdCiudad
                                   join tipoPersona in _context.TipoPersonas on persona.IdTipoPersonaFk equals tipoPersona.IdTipoPersona
                                   where (ciudad.NombreCiudad == "Girón" || ciudad.NombreCiudad == "Piedecuesta") &&
                                         tipoPersona.Descripcion == "Empleado"
                                   select new
                                   {
                                       NombreEmpleado = persona.Nombre,
                                       Ciudad = ciudad.NombreCiudad
                                   };

            return GironPiedecuesta;

        }

  /*       public async Task<IEnumerable<object>> Antiguedad()
        {

            var clientesAntiguedad = from persona in _context.Personas
                                     join contrato in _context.Contratos on persona.Id equals contrato.IdPersonaFk
                                     join tipoPersona in _context.TipoPersonas on persona.IdTipoPersonaFk equals tipoPersona.IdTipoPersona
                                     where tipoPersona.Descripcion == "Cliente" && (DateTime.Now - persona.Registro).TotalDays > (5 * 365) // Más de 5 años
                                     select new
                                     {
                                         NombreCliente = persona.Nombre,
                                         Antiguedad = (DateTime.Now - persona.Registro).TotalDays / 365 // En años
                                     };
            return clientesAntiguedad;
        } */






    }
}
