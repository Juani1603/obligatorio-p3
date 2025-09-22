using Microsoft.EntityFrameworkCore;
using Negocio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.ValueObjects
{
    [Owned]
    public class Email
    {
        public string Correo { get; set; }

        public Email() {  }
        public Email(string correo)
        {
            this.Correo = correo;
            this.Validar();
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(this.Correo))
            {
                throw new UsuarioException("El correo no puede estar vacío");
            }
        }
    }
}
