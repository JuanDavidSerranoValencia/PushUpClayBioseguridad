using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Programacion : BaseEntity
    {
        public int IdProgramacion { get; set; }

        public int IdContratoFk { get; set; }

        public int IdTurnoFk { get; set; }

        public int IdPersonaFk { get; set; }

        public virtual Contrato IdContratoFkNavigation { get; set; }

        public virtual Persona IdPersonaFkNavigation { get; set; }

        public virtual Turno IdTurnoFkNavigation { get; set; }
    }
}