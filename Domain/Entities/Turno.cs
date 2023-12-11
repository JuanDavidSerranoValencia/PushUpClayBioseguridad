using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Turno : BaseEntity
    {
        public int IdTurnos { get; set; }

        public string NombreTurnos { get; set; }

        public string HoraTurnoIng { get; set; }

        public string HoraTurnoFin { get; set; }

        public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
    }
}