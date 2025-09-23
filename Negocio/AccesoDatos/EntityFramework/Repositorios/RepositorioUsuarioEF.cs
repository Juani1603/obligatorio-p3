using Negocio.Entidades;
using Negocio.Exceptions;
using Negocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.EntityFramework.Repositorios
{
    public class RepositorioUsuarioEF : IUsuarioRepositorio
    {
        private NegocioContext _context;

        public RepositorioUsuarioEF(NegocioContext context)
        {
            _context = context;
        }

        public Usuario Login(string email, string contrasena)
        {
            Usuario logueado = _context.Usuarios.Where(
                user =>
                user.Email.Correo == email
                && user.Contrasena == contrasena
            ).FirstOrDefault();

            if (logueado == null)
            {
                throw new UsuarioException("Usuario o contraseña incorrecta.");
            }

            return logueado;
        }

        public void Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> FindAll()
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            Usuario usuario = _context.Usuarios.Where(
               user => user.Id == id
           ).FirstOrDefault();

            if (usuario == null)
            {
                throw new UsuarioException("No se encontró el Id de ese usuario.");
            }

            return usuario;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
