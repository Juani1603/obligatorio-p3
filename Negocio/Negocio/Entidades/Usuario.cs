using Negocio.Enum;
using Negocio.ValueObjects;
using Negocio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public NombreCompleto NombreCompleto { get; set; }
        public string Contrasena { get; set; }
        public Email Email { get; set; }
        public int EquipoId { get; set; }
        public Rol Rol { get; set; }

        public Usuario() { }
        public Usuario(NombreCompleto nombreCompleto, string contrasena, Email email, int equipoId, Rol rol)
        {
            this.NombreCompleto = nombreCompleto;
            this.Contrasena = contrasena;
            this.Email = email;
            this.EquipoId = equipoId;
            this.Rol = rol;
        }

        public void Validar()
        {
            if (this.NombreCompleto == null || string.IsNullOrEmpty(this.Contrasena) ||
                this.Email == null || this.EquipoId < 0)
            {
                throw new UsuarioException("El usuario debe tener nombre, apellido, contraseña, email y un equipo.");
            }
        }
    }
}
