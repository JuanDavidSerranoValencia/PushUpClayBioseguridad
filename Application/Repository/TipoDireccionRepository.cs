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
    public class TipoDireccionRepository : GenericRepository<TipoDireccion> , ITipoDireccion 
    { 
        public PushUpClayBioseguridadContext _context { get; set; } 
        public TipoDireccionRepository(PushUpClayBioseguridadContext context) : base(context) 
        { 
            _context = context; 
        } 
    } 
} 
