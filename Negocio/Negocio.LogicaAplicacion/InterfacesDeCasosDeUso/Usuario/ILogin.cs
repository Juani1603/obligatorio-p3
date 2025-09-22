using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.LogicaAplicacion.DTOs;

namespace Negocio.LogicaAplicacion.InterfacesDeCasosDeUso.Usuario
{
    public interface ILogin
    {
        public UsuarioDTO Login(string email, string contrasena);
    }
}
