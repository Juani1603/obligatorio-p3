using Negocio.LogicaAplicacion.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.Usuario
{
    public interface IObtenerUsuarioPorId
    {
        public UsuarioDTO BuscarUsuarioPorId(int id);
    }
}
