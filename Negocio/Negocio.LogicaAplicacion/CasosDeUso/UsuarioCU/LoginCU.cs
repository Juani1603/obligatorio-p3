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
    public class LoginCU : ILogin
    {
        private IUsuarioRepositorio _repositorio;
        public LoginCU(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public UsuarioDTO Login(string email, string contrasena)
        {
            return UsuarioMapper.ToDTO(_repositorio.Login(email.ToLower(), contrasena));
        }
    }
}
