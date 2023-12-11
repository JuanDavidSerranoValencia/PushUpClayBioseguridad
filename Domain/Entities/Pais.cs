using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pais : BaseEntity
    {
        public int IdPais { get; set; }

        public string NombrePais { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
    }
}