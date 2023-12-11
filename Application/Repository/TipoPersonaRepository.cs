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
    public class TipoPersonaRepository : GenericRepository<TipoPersona> , ITipoPersona 
    { 
        public PushUpClayBioseguridadContext _context { get; set; } 
        public TipoPersonaRepository(PushUpClayBioseguridadContext context) : base(context) 
        { 
            _context = context; 
        } 

        public async Task<IEnumerable<object>> EmpleadosSeguridad()
        {
             var empleados = from persona in _context.Personas
                        join tipoPersona in _context.TipoPersonas on persona.IdTipoPersonaFk equals tipoPersona.IdTipoPersona
                        join ciudad in _context.Ciudads on persona.IdCiudadFk equals ciudad.IdCiudad
                        where tipoPersona.Descripcion == "Empleado"
                        select new
                        {
                            NombreEmpleado = persona.Nombre,
                            TipoPersona = tipoPersona.Descripcion,
                            Ciudad = ciudad.NombreCiudad
                        };
            
            return empleados ;
        }

          public async Task<IEnumerable<object>> Vigilantes()
        {
           var vigilantes = from persona in _context.Personas
                         join tipoPersona in _context.TipoPersonas on persona.IdTipoPersonaFk equals tipoPersona.IdTipoPersona
                         where tipoPersona.Descripcion == "Empleado" && tipoPersona.Descripcion == "Vigilante"
                         select new
                         {
                             NombreEmpleado = persona.Nombre,
                             TipoPersona = tipoPersona.Descripcion,
                            
                         };
            
            return vigilantes;
        }

       
    } 
} 
