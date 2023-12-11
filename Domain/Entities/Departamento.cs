using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento: BaseEntity
    {
         public int IdDepartamento { get; set; }

    public string NombreDep { get; set; }

    public int IdPaisFk { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Pais IdPaisFkNavigation { get; set; }
    }
}