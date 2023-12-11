using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{ 
    public interface ITipoPersona:IGeneric<TipoPersona> 
    {
        Task<IEnumerable<object>> EmpleadosSeguridad ();
        Task<IEnumerable<object>> Vigilantes ();
    }
} 
