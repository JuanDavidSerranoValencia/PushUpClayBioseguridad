using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IPersona : IGeneric<Persona>
    {
        Task<IEnumerable<object>> ContactosVigilantes();
        Task<IEnumerable<object>> ClientesBucaramanga();
        Task<IEnumerable<object>> GironPiedecuesta();
    }
}
