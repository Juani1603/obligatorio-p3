using Negocio.Entidades;
using Negocio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.LogicaAplicacion.DTOs
{
    public class UsuarioDTO
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public int EquipoId {  get; set; }
        public Rol Rol {  get; set; }
    }
}
