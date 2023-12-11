using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ciudad : BaseEntity
    {
        public int IdCiudad { get; set; }

        public string NombreCiudad { get; set; }

        public int IdDepartamentoFk { get; set; }

        public virtual Departamento IdDepartamentoFkNavigation { get; set; }

        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
    }
}