using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DireccionPersona: BaseEntity
    {
          public int IdDirPersona { get; set; }

    public string Direccion { get; set; }

    public int IdPersonaFk { get; set; }

    public int IdTipoDireccionFk { get; set; }

    public virtual Persona IdPersonaFkNavigation { get; set; }

    public virtual TipoDireccion IdTipoDireccionFkNavigation { get; set; }
    }
}