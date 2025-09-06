using Negocio.Enum;
using Negocio.ValueObjects;
using Negocio.Exceptions
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Usuario
    {
        public NombreCompleto NombreCompleto { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public Equipo Equipo { get; set; }
        public Rol Rol { get; set; }

        public Usuario() { }
        public Usuario(NombreCompleto nombreCompleto, string contrasena, string email, Equipo equipo, Rol rol)
        {
            this.NombreCompleto = nombreCompleto;
            this.Contrasena = contrasena;
            this.Email = email;
            this.Equipo = equipo;
            this.Rol = rol;
        }

        public void Validar()
        {
            if (this.NombreCompleto == null || string.IsNullOrEmpty(this.Contrasena) ||
                string.IsNullOrEmpty(this.Email) || this.Equipo == null)
            {
                throw new UsuarioException("El usuario debe tener nombre, apellido, contraseña, email y un equipo.");
            }
        }
    }
}
