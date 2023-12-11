using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoDireccion: BaseEntity
    {
        public int IdTipoDireccion { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<DireccionPersona> Direccionpersonas { get; set; } = new List<DireccionPersona>();
    }
}