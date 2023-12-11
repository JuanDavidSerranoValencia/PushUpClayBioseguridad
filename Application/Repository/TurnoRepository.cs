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
    public class TurnoRepository : GenericRepository<Turno> , ITurno 
    { 
        public PushUpClayBioseguridadContext _context { get; set; } 
        public TurnoRepository(PushUpClayBioseguridadContext context) : base(context) 
        { 
            _context = context; 
        } 
    } 
} 
