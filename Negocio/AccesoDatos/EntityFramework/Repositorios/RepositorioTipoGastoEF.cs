using Negocio.Entidades;
using Negocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.EntityFramework.Repositorios
{
    public class RepositorioTipoGastoEF : ITipoGastoRepositorio
    {
        private NegocioContext _context;

        public RepositorioTipoGastoEF(NegocioContext context)
        {
            _context = new NegocioContext();
        }

        public void Add(TipoGasto obj)
        {
            obj.Validar();
            _context.Add(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TipoGasto> FindAll()
        {
            return _context.TipoGastos;
        }

        public TipoGasto FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoGasto obj)
        {
            throw new NotImplementedException();
        }
    }
}
