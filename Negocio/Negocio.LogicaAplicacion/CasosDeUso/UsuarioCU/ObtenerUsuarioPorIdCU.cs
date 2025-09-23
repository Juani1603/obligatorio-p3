using Negocio.InterfacesRepositorio;
using Negocio.LogicaAplicacion.DTOs;
using Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.Usuario;
using Negocio.LogicaAplicacion.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LogicaAplicacion.CasosDeUso.UsuarioCU
{
    public class ObtenerUsuarioPorIdCU : IObtenerUsuarioPorId
    {
        private IUsuarioRepositorio _repositorio;

        public ObtenerUsuarioPorIdCU(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public UsuarioDTO BuscarUsuarioPorId(int id)
        {
            return UsuarioMapper.ToDTO(_repositorio.FindById(id));
        }
    }
}
