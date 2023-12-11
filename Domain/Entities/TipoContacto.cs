using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoContacto: BaseEntity
    {
        public int IdTipoContacto { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<ContactoPersona> Contactopersonas { get; set; } = new List<ContactoPersona>();
    }
}