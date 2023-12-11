using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona: BaseEntity
    {
    
    public uint IdPersona { get; set; }

    public string Nombre { get; set; }

    public DateOnly Registro { get; set; }

    public int IdTipoPersonaFk { get; set; }

    public int IdCiudadFk { get; set; }

    public int IdCategoriaPersonaFk { get; set; }

    public virtual ICollection<ContactoPersona> Contactopersonas { get; set; } = new List<ContactoPersona>();

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual ICollection<DireccionPersona> Direccionpersonas { get; set; } = new List<DireccionPersona>();

    public virtual CategoriaPersona IdCategoriaPersonaFkNavigation { get; set; }

    public virtual Ciudad IdCiudadFkNavigation { get; set; }

    public virtual TipoPersona IdTipoPersonaFkNavigation { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
    }
}