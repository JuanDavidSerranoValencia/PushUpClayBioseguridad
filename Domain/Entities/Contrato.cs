using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contrato : BaseEntity
    {
        

        public DateOnly FechaContrato { get; set; }

        public DateOnly? FechaFin { get; set; }

        public int IdEstadoFk { get; set; }

        public int IdPersonaFk { get; set; }

        public virtual Estado IdEstadoFkNavigation { get; set; }

        public virtual Persona IdPersonaFkNavigation { get; set; }

        public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
    }
}