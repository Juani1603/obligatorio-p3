using Negocio.Entidades;
using Negocio.Exceptions;
using Negocio.InterfacesRepositorio;
using Negocio.ValueObjects;
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
            _context = context;
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
            TipoGasto tipoGasto = _context.TipoGastos.Where(
                tp => tp.Id == id
            ).FirstOrDefault();

            if (tipoGasto == null)
            {
                throw new TipoGastoException("No se encontró ese Tipo de gasto por Id");
            }

            return tipoGasto;
        }


        public void Remove(int id)
        {
            TipoGasto tipoGasto = new TipoGasto { Id = id };
            _context.TipoGastos.Remove(tipoGasto);
            _context.SaveChanges();
        }

        public void Update(TipoGasto obj)
        {
            _context.TipoGastos.Update(obj);
            _context.SaveChanges();
        }
    }
}
