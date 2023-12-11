using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;
namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly PushUpClayBioseguridadContext _context;
    public UnitOfWork(PushUpClayBioseguridadContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }
    private ICategoriaPersona _categoriapersonas;
    private ICiudad _ciudads;
    private IContactoPersona _contactopersonas;
    private IContrato _contratos;
    private IDepartamento _departamentos;
    private IDireccionPersona _direccionpersonas;
    private IEstado _estados;
    private IPais _paiss;
    private IPersona _personas;
    private IProgramacion _programacions;
  
    private ITipoContacto _tipocontactos;
    private ITipoDireccion _tipodireccions;
    private ITipoPersona _tipopersonas;
    private ITurno _turnos;
    public ICategoriaPersona CategoriaPersonas {
        get
        {
            if(_categoriapersonas == null) 
            {
                _categoriapersonas = new CategoriaPersonaRepository(_context);
            }
            return _categoriapersonas;
        }
    }
    public ICiudad Ciudads {
        get
        {
            if(_ciudads == null) 
            {
                _ciudads = new CiudadRepository(_context);
            }
            return _ciudads;
        }
    }
    public IContactoPersona ContactoPersonas {
        get
        {
            if(_contactopersonas == null) 
            {
                _contactopersonas = new ContactoPersonaRepository(_context);
            }
            return _contactopersonas;
        }
    }
    public IContrato Contratos {
        get
        {
            if(_contratos == null) 
            {
                _contratos = new ContratoRepository(_context);
            }
            return _contratos;
        }
    }
    public IDepartamento Departamentos {
        get
        {
            if(_departamentos == null) 
            {
                _departamentos = new DepartamentoRepository(_context);
            }
            return _departamentos;
        }
    }
    public IDireccionPersona DireccionPersonas {
        get
        {
            if(_direccionpersonas == null) 
            {
                _direccionpersonas = new DireccionPersonaRepository(_context);
            }
            return _direccionpersonas;
        }
    }
    public IEstado Estados {
        get
        {
            if(_estados == null) 
            {
                _estados = new EstadoRepository(_context);
            }
            return _estados;
        }
    }
    public IPais Paiss {
        get
        {
            if(_paiss == null) 
            {
                _paiss = new PaisRepository(_context);
            }
            return _paiss;
        }
    }
    public IPersona Personas {
        get
        {
            if(_personas == null) 
            {
                _personas = new PersonaRepository(_context);
            }
            return _personas;
        }
    }
    public IProgramacion Programacions {
        get
        {
            if(_programacions == null) 
            {
                _programacions = new ProgramacionRepository(_context);
            }
            return _programacions;
        }
    }

    public ITipoContacto TipoContactos {
        get
        {
            if(_tipocontactos == null) 
            {
                _tipocontactos = new TipoContactoRepository(_context);
            }
            return _tipocontactos;
        }
    }
    public ITipoDireccion TipoDireccions {
        get
        {
            if(_tipodireccions == null) 
            {
                _tipodireccions = new TipoDireccionRepository(_context);
            }
            return _tipodireccions;
        }
    }
    public ITipoPersona TipoPersonas {
        get
        {
            if(_tipopersonas == null) 
            {
                _tipopersonas = new TipoPersonaRepository(_context);
            }
            return _tipopersonas;
        }
    }
    public ITurno Turnos {
        get
        {
            if(_turnos == null) 
            {
                _turnos = new TurnoRepository(_context);
            }
            return _turnos;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
