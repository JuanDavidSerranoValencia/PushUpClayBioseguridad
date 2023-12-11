using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContactoPersona : BaseEntity
    {
        public int IdContactoPersona { get; set; }

        public string Descripcion { get; set; }

        public int IdPersonaFk { get; set; }

        public int IdTipoContactoFk { get; set; }

        public virtual Persona IdPersonaFkNavigation { get; set; }

        public virtual TipoContacto IdTipoContactoFkNavigation { get; set; }
    }
}